/* --------------------------------------------------------------------------------------------
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for license information.
 * -------------------------------------------------------------------------------------------- */

import { IEventEmitterFactory } from '../IEventEmitterFactory';
import { IRazorDocumentChangeEvent } from '../IRazorDocumentChangeEvent';
import { IRazorDocumentManager } from '../IRazorDocumentManager';
import { RazorDocumentChangeKind } from '../RazorDocumentChangeKind';
import { RazorLogger } from '../RazorLogger';
import { getUriPath } from '../UriPaths';
import * as vscode from '../vscodeAdapter';
import { IRazorDocument } from '../IRazorDocument';

export class HtmlProjectedDocumentContentProvider implements vscode.TextDocumentContentProvider {
    public static readonly scheme = 'razor-html';

    private readonly onDidChangeEmitter: vscode.EventEmitter<vscode.Uri>;

    constructor(
        private readonly documentManager: IRazorDocumentManager,
        eventEmitterFactory: IEventEmitterFactory,
        private readonly logger: RazorLogger) {
        documentManager.onChange((event) => this.documentChanged(event));
        this.onDidChangeEmitter = eventEmitterFactory.create<vscode.Uri>();
    }

    public get onDidChange(): vscode.Event<vscode.Uri> {
        return this.onDidChangeEmitter.event;
    }

    public provideTextDocumentContent(uri: vscode.Uri): string {
        const razorDocument = this.findRazorDocument(uri);
        if (!razorDocument) {
            // Document was removed from the document manager, meaning there's no more content for this
            // file. Report an empty document.

            if (this.logger.verboseEnabled) {
                this.logger.logVerbose(
                    `Could not find document '${getUriPath(uri)}' when updating the HTML buffer. This typically happens when a document is removed.`);
            }
            return '';
        }

        const content = `${razorDocument.htmlDocument.getContent()}
// ${razorDocument.htmlDocument.projectedDocumentSyncVersion}`;

        return content;
    }

    private documentChanged(event: IRazorDocumentChangeEvent): void {
        if (event.kind === RazorDocumentChangeKind.htmlChanged ||
            event.kind === RazorDocumentChangeKind.opened ||
            event.kind === RazorDocumentChangeKind.removed) {
            // We also notify changes on document removal in order to tell VSCode that there's no more
            // HTML content for the file.

            this.onDidChangeEmitter.fire(event.document.htmlDocument.uri);
        }
    }

    private findRazorDocument(uri: vscode.Uri): IRazorDocument | undefined {
        const projectedPath = getUriPath(uri);

        return this.documentManager.documents.find(razorDocument =>
            razorDocument.htmlDocument.path.localeCompare(
                projectedPath, undefined, { sensitivity: 'base' }) === 0);
    }
}

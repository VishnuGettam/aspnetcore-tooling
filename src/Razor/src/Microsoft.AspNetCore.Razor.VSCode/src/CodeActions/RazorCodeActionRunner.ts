/* --------------------------------------------------------------------------------------------
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for license information.
 * ------------------------------------------------------------------------------------------ */

import * as vscode from 'vscode';
import { RazorLanguageServerClient } from '../RazorLanguageServerClient';
import { RazorLogger } from '../RazorLogger';
import { CodeActionResolutionRequest } from '../RPC/CodeActionResolutionRequest';
import { CodeActionResolutionResponse } from '../RPC/CodeActionResolutionResponse';
import { convertWorkspaceEditFromSerializable } from '../RPC/SerializableWorkspaceEdit';

export class RazorCodeActionRunner {

    constructor(
        private readonly serverClient: RazorLanguageServerClient,
        private readonly logger: RazorLogger,
    ) {}

    public register() {
        vscode.commands.registerCommand('razor/runCodeAction', (request: CodeActionResolutionRequest) => this.runCodeAction(request), this);
    }

    private async runCodeAction(request: CodeActionResolutionRequest): Promise<boolean> {
        const response: CodeActionResolutionResponse = await this.serverClient.sendRequest('razor/resolveCodeAction', {Action: request.Action, Data: request.Data});
        let workspaceEdit: vscode.WorkspaceEdit;
        this.logger.logAlways(`response ${JSON.stringify(response)}`);
        try {
            workspaceEdit = convertWorkspaceEditFromSerializable(response.edit);
        } catch (error) {
            this.logger.logError(`Unexpected error deserializing code action for ${request.Action}`, error);
            return Promise.resolve(false);
        }
        return vscode.workspace.applyEdit(workspaceEdit);
    }
}

/* --------------------------------------------------------------------------------------------
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for license information.
 * ------------------------------------------------------------------------------------------ */

import * as vscode from 'vscode';
import { RazorLanguageServerClient } from '../RazorLanguageServerClient';
import { RazorLogger } from '../RazorLogger';
<<<<<<< HEAD
import { CodeActionResolutionRequest } from '../RPC/CodeActionResolutionRequest';
=======
>>>>>>> 37e5556eaa396241dea8f4062d9f290872a68c63
import { CodeActionResolutionResponse } from '../RPC/CodeActionResolutionResponse';
import { convertWorkspaceEditFromSerializable } from '../RPC/SerializableWorkspaceEdit';

export class RazorCodeActionRunner {

    constructor(
        private readonly serverClient: RazorLanguageServerClient,
        private readonly logger: RazorLogger,
    ) {}

    public register() {
<<<<<<< HEAD
        vscode.commands.registerCommand('razor/runCodeAction', (request: CodeActionResolutionRequest) => this.runCodeAction(request), this);
    }

    private async runCodeAction(request: CodeActionResolutionRequest): Promise<boolean> {
=======
        vscode.commands.registerCommand('razor/runCodeAction', request => this.runCodeAction(request), this);
    }

    private async runCodeAction(request: any): Promise<boolean> {
>>>>>>> 37e5556eaa396241dea8f4062d9f290872a68c63
        const response: CodeActionResolutionResponse = await this.serverClient.sendRequest('razor/resolveCodeAction', {Action: request.Action, Data: request.Data});
        let workspaceEdit: vscode.WorkspaceEdit;
        this.logger.logAlways(`response ${JSON.stringify(response)}`);
        try {
            workspaceEdit = convertWorkspaceEditFromSerializable(response.edit);
<<<<<<< HEAD
        } catch (error) {
            this.logger.logError(`Unexpected error deserializing code action for ${request.Action}`, error);
=======
        } catch (e) {
            this.logger.logAlways(`caught error running code action: ${e}`);
>>>>>>> 37e5556eaa396241dea8f4062d9f290872a68c63
            return Promise.resolve(false);
        }
        return vscode.workspace.applyEdit(workspaceEdit);
    }
}

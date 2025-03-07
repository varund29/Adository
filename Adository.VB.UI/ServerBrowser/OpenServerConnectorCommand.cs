﻿using Adository.VB.UI.ServerConnector;
using System;

namespace Adository.VB.UI.ServerBrowser
{
    public class OpenServerConnectorCommand : ServerBrowserCommandBase
    {
        public OpenServerConnectorCommand(ServerBrowserForm form) : base(form)
        {
        }

        protected override void InitEvents()
        {
            Form.openServerConnectorButton.Click += OnClick;
        }

        private void OnClick(object sender, EventArgs e)
        {
            OpenServerConnectorForm();
        }

        private void OpenServerConnectorForm()
        {
            ServerConnectorForm frmLogin = new ServerConnectorForm(Form);
            frmLogin.ShowDialog();
        }
    }
}

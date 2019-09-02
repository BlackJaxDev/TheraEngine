using System;
using System.Windows.Forms;
using TheraEngine;
using TheraEngine.Core.Files;

namespace TheraEditor.Windows.Forms
{
    public abstract class DockableRenderableFileEditor<TFile, TRenderHandler> : DockableFileEditor<TFile>
        where TFile : class, IFileObject
        where TRenderHandler : class, IUIRenderHandler
    {
        public RenderPanel<TRenderHandler> RenderPanel { get; private set; }
        public abstract bool ShouldHideCursor { get; }
        
        public DockableRenderableFileEditor()
        {
            InitializeComponent();
        }

        protected void RenderPanel_GotFocus(object sender, EventArgs e)
        {
            if (File != null)
                Editor.Instance.PropertyGridForm.PropertyGrid.TargetObject = File;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            RenderPanel.RenderHandler.FormShown();
        }
        protected override void OnClosed(EventArgs e)
        {
            RenderPanel.RenderHandler.FormClosed();
            base.OnClosed(e);
        }
        private void RenderPanel_MouseEnter(object sender, EventArgs e)
        {
            if (ShouldHideCursor)
                Cursor.Hide();
        }
        private void RenderPanel_MouseLeave(object sender, EventArgs e)
        {
            if (ShouldHideCursor)
                Cursor.Show();
        }
        private void InitializeComponent()
        {
            RenderPanel = new RenderPanel<TRenderHandler>();

            SuspendLayout();

            RenderPanel.AllowDrop = false;
            RenderPanel.Dock = DockStyle.Fill;
            RenderPanel.Location = new System.Drawing.Point(0, 0);
            RenderPanel.Margin = new Padding(0);
            RenderPanel.Name = "RenderPanel";
            RenderPanel.MouseEnter += RenderPanel_MouseEnter;
            RenderPanel.MouseLeave += RenderPanel_MouseLeave;
            Controls.Add(RenderPanel);

            ResumeLayout(false);
        }
    }
}

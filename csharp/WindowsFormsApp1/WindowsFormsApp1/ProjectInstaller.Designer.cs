namespace WindowsFormsApp1
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectInstaller));
            this.performanceCounterInstaller1 = new System.Diagnostics.PerformanceCounterInstaller();
            // 
            // performanceCounterInstaller1
            // 
            this.performanceCounterInstaller1.CategoryName = "SkidataCounts";
            this.performanceCounterInstaller1.Counters.AddRange(new System.Diagnostics.CounterCreationData[] {
            ((System.Diagnostics.CounterCreationData)(resources.GetObject("performanceCounterInstaller1.Counters")))});
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.performanceCounterInstaller1});

        }

        #endregion

        private System.Diagnostics.PerformanceCounterInstaller performanceCounterInstaller1;
    }
}
using System;


namespace R5T.O0021
{
    public class WorkspaceOperations : IWorkspaceOperations
    {
        #region Infrastructure

        public static IWorkspaceOperations Instance { get; } = new WorkspaceOperations();


        private WorkspaceOperations()
        {
        }

        #endregion
    }
}

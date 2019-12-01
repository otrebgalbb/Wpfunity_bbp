

using BBP.HOME.Boilerpate.Properties;

using Microsoft.Extensions.Logging;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BBP.HOME.Boilerpate.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        #region Fields
       
        #endregion

        #region Dialog Service

private ILoggerFactory loggerFactory;
        #endregion Dialog Service

        #region constructor
        /// <summary>
        /// The Mainview model
        /// </summary>
        /// <param name="loggerFactory">Logger factory</param>
        /// <param name="parameterManager">Parameter manager</param>
        /// <param name="workspaceManager">Workspace manager</param>
        /// <param name="eventAggregator">Event Aggregator</param>
        /// <param name="documentationManager">Documantation manager</param>
        /// <param name="converterManager">converter manager</param>
        /// <param name="moManager">mo manager</param>
        /// <param name="loadingHelper">loading helper</param>
        /// <param name="resultViewModel">result view model</param>

        public MainWindowViewModel(ILoggerFactory loggerFactory

            )
        {
            this.loggerFactory = loggerFactory;
       
        }
     


        #endregion
        #region Commands

        #endregion
        #region Properties
      
        #endregion

        #region Public Methods
       
        #endregion

        #region Private Methods
      
        #endregion

    }
}

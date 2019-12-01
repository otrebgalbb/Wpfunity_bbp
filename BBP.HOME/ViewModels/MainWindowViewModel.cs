

using BBP.HOME.Boilerpate.Properties;

using Microsoft.Extensions.Logging;
using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private ILoggerFactory loggerFactory;
        private ILogger<MainWindowViewModel> logger;
        private string name;
        private ObservableCollection<string> results;
        private bool isListChecked;
        #endregion

        #region Dialog Service


        #endregion Dialog Service

        #region constructor
        /// <summary>
        /// The Mainview model
        /// </summary>
        /// <param name="loggerFactory">Logger factory</param>


        public MainWindowViewModel(ILoggerFactory loggerFactory)
        {
            this.loggerFactory = loggerFactory;
            this.logger = loggerFactory.CreateLogger<MainWindowViewModel>();
            ButtonCommand = new DelegateCommand(OnPressButton);

            //
            Name = "vide";
            Results = new ObservableCollection<string>();
            var liste = new List<string>();
            liste.Add("item 1");
            liste.Add("item 2");
            liste.Add("item 3");
            Results.AddRange(liste);
            IsListChecked = false;
        }

        #endregion
        #region Commands
        public ICommand ButtonCommand { get; }
        #endregion
        #region Properties



        public void OnPressButton()
        {
            Name = "New text";
            IsListChecked = true;
        }

        //
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value, nameof(Name)); }
        }

        public bool IsListChecked
        {
            get { return isListChecked; }
            set { SetProperty(ref isListChecked, value, nameof(IsListChecked)); }
        }

        //
        public ObservableCollection<string> Results
        {
            get => results;
            set { SetProperty(ref results, value, nameof(Results)); }
        }

        #endregion

        #region Public Methods

        #endregion

        #region Private Methods

        #endregion

    }
}

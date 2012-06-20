using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvvmSample.Models;
using System.Windows.Input;
using System.Windows;

namespace MvvmSample.ViewModels
{
    class LineOfTextViewModel : ViewModelBase
    {
        #region Fields

        LineOfText _lineOfText;

        ICommand _showMessageCommand;

        #endregion

        #region Constructors

        public LineOfTextViewModel()
            : this(new LineOfText())
        {}

        public LineOfTextViewModel(LineOfText lineOfText)
        {
            _lineOfText = lineOfText;
        }

        #endregion

        #region Properties

        public string Line
        {
            get { return _lineOfText.Line; }
            set
            {
                if (value != _lineOfText.Line)
                {
                    _lineOfText.Line = value;
                    OnPropertyChanged("Line");
                }
            }
        }

        public ICommand ShowMessageCommand
        {
            get
            {
                if (_showMessageCommand == null)
                {
                    _showMessageCommand = new RelayCommand(ShowMessage, CanShowMessage);
                }

                return _showMessageCommand;
            }
        }

        #endregion

        #region Command helpers

        private void ShowMessage(object parameter)
        {
            MessageBox.Show(_lineOfText.Line);
        }

        private bool CanShowMessage(object parameter)
        {
            return _lineOfText != null && !string.IsNullOrWhiteSpace(_lineOfText.Line);
        }
        #endregion
    }
}

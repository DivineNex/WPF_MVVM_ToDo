using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;
using WPF_MVVM_ToDo.Commands;

namespace WPF_MVVM_ToDo.ViewModels.Controls
{
    internal class ColorPickerPanelViewModel : ViewModel
    {
		public HomeScreenViewModel HomeScreenViewModel { get; private set; }

		#region SelectedColor
		private Color _selectedColor;
		public Color SelectedColor
		{
			get { return _selectedColor; }
			set
			{
				_selectedColor = value;
				if (HomeScreenViewModel.SelectedTaskCard != null)
					HomeScreenViewModel.SelectedTaskCard.BackgroundColorBrush = new SolidColorBrush(value);

				for (int i = 0; i < _borderThicknesses.Count; i++)
					_borderThicknesses[i] = new Thickness(0);

				if (value == (Color)ColorConverter.ConvertFromString("#E4CDEE"))
					_borderThicknesses[0] = new Thickness(4);
                else if (value == (Color)ColorConverter.ConvertFromString("#FAC2D9"))
                    _borderThicknesses[1] = new Thickness(4);
                else if (value == (Color)ColorConverter.ConvertFromString("#F0C8CF"))
                    _borderThicknesses[2] = new Thickness(4);
                else if (value == (Color)ColorConverter.ConvertFromString("#E6DADE"))
                    _borderThicknesses[3] = new Thickness(4);
                else if (value == (Color)ColorConverter.ConvertFromString("#CFDDDB"))
                    _borderThicknesses[4] = new Thickness(4);
                else if (value == (Color)ColorConverter.ConvertFromString("#C3E9DE"))
                    _borderThicknesses[5] = new Thickness(4);
                else if (value == (Color)ColorConverter.ConvertFromString("#C2DBE9"))
                    _borderThicknesses[6] = new Thickness(4);
                else if (value == (Color)ColorConverter.ConvertFromString("#C9CAEE"))
                    _borderThicknesses[7] = new Thickness(4);
            }
		}
		#endregion

		#region BorderThicknesses
		private ObservableCollection<Thickness> _borderThicknesses;

		public ObservableCollection<Thickness> BorderThicknesses
		{
			get { return _borderThicknesses; }
			set { Set(ref _borderThicknesses, value, nameof(BorderThicknesses)); }
		}
		#endregion

		public SelectColorInColorPickerCommand SelectColorInColorPickerCommand { get; set; }

        public ColorPickerPanelViewModel(HomeScreenViewModel homeScreenViewModel)
		{
			SelectColorInColorPickerCommand = new SelectColorInColorPickerCommand(this);

			HomeScreenViewModel = homeScreenViewModel;

			_borderThicknesses = new ObservableCollection<Thickness>()
			{
				new Thickness(0),
				new Thickness(0),
				new Thickness(0),
				new Thickness(0),
				new Thickness(0),
				new Thickness(0),
				new Thickness(0),
				new Thickness(0)
			};
		}
	}
}

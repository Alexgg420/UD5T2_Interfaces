using UD5T2.MVVM.Models;

namespace UD5T2.MVVM.ViewModels
{
    /// <summary>
    /// Clase que representa el ViewModel para la vista BMIView
    /// </summary>
    public class BMIViewModel
    {
        /// <summary>
        /// Modelo BMI asociado al ViewModel
        /// </summary>
        public BMI BMI { get; set; }

        /// <summary>
        /// Constructor de la clase BMIViewModel.
        /// Inicializa un objeto BMI con valores predeterminados
        /// </summary>
        public BMIViewModel()
        {
            BMI = new BMI
            {
                Peso = 50,
                Altura = 25
            };
        }
    }
}

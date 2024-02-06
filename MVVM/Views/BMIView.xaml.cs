///////////////////////////////////////////
// Tarea: UD5T2
// Alumno/a: Alejandro Giráldez Guerrero
// Curso: 2023/2024
///////////////////////////////////////////

using UD5T2.MVVM.ViewModels;

namespace UD5T2.MVVM.Views
{
    /// <summary>
    /// Clase que representa la vista BMIView
    /// </summary>
    public partial class BMIView : ContentPage
    {
        /// <summary>
        /// Constructor de la clase BMIView.
        /// Inicializa la vista y establece el contexto de enlace al ViewModel BMIViewMode
        /// </summary>
        public BMIView()
        {
            InitializeComponent();

            // Establecer el contexto de enlace al ViewModel
            BindingContext = new BMIViewModel();
        }
    }
}
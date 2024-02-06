///////////////////////////////////////////
// Tarea: UD5T2
// Alumno/a: Alejandro Giráldez Guerrero
// Curso: 2023/2024
///////////////////////////////////////////

using System.ComponentModel;

namespace UD5T2.MVVM.Models
{
    /// <summary>
    /// Clase que representa un modelo para el Índice de Masa Corporal (BMI).
    /// Implementa la interfaz INotifyPropertyChanged para notificar cambios en las propiedades.
    /// </summary>
    public class BMI : INotifyPropertyChanged
    {
        private float altura;

        /// <summary>
        /// Altura en centímetros
        /// </summary>
        public float Altura
        {
            get => altura;
            set
            {
                if (altura != value)
                {
                    altura = value;
                    OnPropertyChanged(nameof(Altura));
                    OnPropertyChanged(nameof(Resultado));
                    OnPropertyChanged(nameof(ResultadoBMI));
                }
            }
        }

        private float peso;

        /// <summary>
        /// Peso en kilogramos
        /// </summary>
        public float Peso
        {
            get => peso;
            set
            {
                if (peso != value)
                {
                    peso = value;
                    OnPropertyChanged(nameof(Peso));
                    OnPropertyChanged(nameof(Resultado));
                    OnPropertyChanged(nameof(ResultadoBMI));
                }
            }
        }

        /// <summary>
        /// Calcula el resultado del Índice de Masa Corporal (BMI)
        /// </summary>
        public float Resultado => (Peso / (Altura * Altura)) * 10000;

        /// <summary>
        /// Obtiene la clasificación del Índice de Masa Corporal (BMI).
        /// </summary>
        public string ResultadoBMI
        {
            get
            {
                if (Resultado <= 16)
                    return "BMI: Delgado Severo";
                else if (Resultado <= 17)
                    return "BMI: Delgado Moderado";
                else if (Resultado <= 18.5)
                    return "BMI: Delgado Medio";
                else if (Resultado <= 25)
                    return "BMI: Normal";
                else if (Resultado <= 30)
                    return "BMI: Sobrepeso";
                else if (Resultado <= 35)
                    return "BMI: Obesidad Clase I";
                else if (Resultado <= 40)
                    return "BMI: Obesidad Clase II";
                else
                    return "BMI: Obesidad Clase III";
            }
        }

        /// <summary>
        /// Evento que se desencadena cuando una propiedad cambia
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Invoca el evento PropertyChanged para notificar cambios en las propiedades
        /// </summary>
        /// <param name="propertyName">Nombre de la propiedad que ha cambiado</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

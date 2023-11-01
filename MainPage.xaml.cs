using System.Collections.ObjectModel;

namespace ToDoApp
{
    public partial class MainPage : ContentPage
    {
        public Tasks Tarea { get; set; }

                public MainPage()
                {
                    InitializeComponent();
                    CreateOneTask();
                    BindingContext = Tarea;
                }

                private void CreateOneTask()
                {
                    Tarea = new Tasks()
                    {
                        TaskName = "Comprar Pan",
                        Status = "Pendiente",
                        ColorText = "Blue"
                    };
                }

        protected override void OnAppearing()
        {
            base.OnAppearing();

        }

        private void AddBtn_Clicked(object sender, EventArgs e)
        {
            Tarea.TaskName = "Otra Tarea";
            Tarea.Status = "Completa";
            Tarea.ColorText = "Red";
        }
    }
}
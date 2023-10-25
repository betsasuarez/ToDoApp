using System.Collections.ObjectModel;

namespace ToDoApp
{
    public partial class MainPage : ContentPage
    {
        public string MyTitle { get; set; } = "Lista de Tareas";
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void AddBnt_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Agregado", "ok");
        }

    }   


}
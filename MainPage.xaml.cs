using System.Collections.ObjectModel;

namespace ToDoApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Tasks> MyTasks { get; set; }
        public Tasks MyTask { get; set; }

        public MainPage()
        {
            InitializeComponent();
            CreateOneTask();
            BindingContext = MyTask;
        }

        private void CreateOneTask()
        {
            MyTask = new Tasks()
            {
                TaskName = "Tarea",
                Status = "Pendiente",
                ColorText = "Blue"
            };
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            //CreateAndLoadTaks();
        }

        private void AddBtn_Clicked(object sender, EventArgs e)
        {

            //DisplayAlert("Alert", "Agregado", "OK");

            // source 
            var MyNewTask = new Tasks()
            {
                TaskName = "Pagar ropa", //
                Status = "Pendiente",
                ColorText = "Red"
            };

            MyNewTask.TaskName = "Terminar Pago";
            MyNewTask.Status = "Completado";



            BindingContext = MyNewTask;

        }
    }
}
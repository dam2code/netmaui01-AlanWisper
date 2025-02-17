using Maui_app7.Models;
using SharedWithYouCore;

namespace Maui_app7
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        public async void OnNewButtonClicked(object sender, EventArgs args)
        {
            statusMessage.Text = "";

            await App.PersonRepo.AddNewPerson(newPerson.Text);
            statusMessage.Text = App.PersonRepo.StatusMessage;
        }

        public async void OnGetButtonClicked(object sender, EventArgs args)
        {
            statusMessage.Text = "";

            List<Person> people = await App.PersonRepo.GetAllPeople();
            peopleList.ItemsSource = people;
        }

    }

}

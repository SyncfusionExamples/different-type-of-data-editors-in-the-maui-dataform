using Syncfusion.Maui.DataForm;

namespace MauiProject;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        dataForm.ItemsSourceProvider = new ItemSourceProviderExt();
        //dataForm.GenerateDataFormItem += OnGenerateDataFormItem;
        //dataForm.RegisterEditor("Country", DataFormEditorType.ComboBox);
    }

    //private void OnGenerateDataFormItem(object sender, GenerateDataFormItemEventArgs e)
    //{
    //    if (e.DataFormItem != null && e.DataFormItem.FieldName == "Country" && e.DataFormItem is DataFormComboBoxItem comboBoxItem)
    //    {
    //        List<string> list = new List<string>() {
    //                "Indonesia",
    //                "Italy",
    //                "India",
    //                "Iran",
    //                "Iraq",
    //                "Uganda",
    //                "Ukraine",
    //                "Canada",
    //                "Australia",
    //                "Uzbekistan",
    //                "France",
    //                "United Kingdom",
    //                "United States"
    //            };
    //        comboBoxItem.ItemsSource = list;
    //    }
    //}

    public class ItemSourceProviderExt : IDataFormSourceProvider
    {
        public object GetSource(string sourceName)
        {
            if (sourceName == "Country")
            {
                List<string> list = new List<string>() {
                    "Indonesia",
                    "Italy",
                    "India",
                    "Iran",
                    "Iraq",
                    "Uganda",
                    "Ukraine",
                    "Canada",
                    "Australia",
                    "Uzbekistan",
                    "France",
                    "United Kingdom",
                    "United States"
                };
                return list;
            }
            return new List<string>();
        }
    }
}



using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;
using Microsoft.Win32;
using System.Xml.Linq;
using Path = System.IO.Path;
using System.Runtime.Serialization;
using System.Xml;
using System.Collections.ObjectModel;

namespace Labb_4 {

    public partial class EditQuiz : UserControl {

        /*
        private ObservableCollection<saveAs_XML_Blueprint> _myDatagridContent;

        public ObservableCollection<saveAs_XML_Blueprint> myDatagridContent
        {
            get { return _myDatagridContent; }
            set { _myDatagridContent = value; }
        }
        */

        private XmlDocument _pleaseLoadXML = new XmlDocument();

        public XmlDocument PleaseLoadXML {
            get { return _pleaseLoadXML; }
            set { _pleaseLoadXML = value; }
        }

        private DataSet myNewDataset;

        private DataTable _datagridToSave = new DataTable();

        public DataTable DatagridToSave {
            get { return _datagridToSave; }
            set { _datagridToSave = value; }
        }

        private bool _isTheDatagridEmpty = true;

        public bool IsTheDatagridEmpty
        {
            get { return _isTheDatagridEmpty; }
            set { _isTheDatagridEmpty = value; }
        }
        
        private saveAs_XML_Blueprint _aNewQuiz = new saveAs_XML_Blueprint();

        public saveAs_XML_Blueprint ANewQuiz {
            get { return _aNewQuiz; }
            set { _aNewQuiz = value; }
        }

        private string _modifyQuiz;

        public string ModifyQuiz
        {
            get { return _modifyQuiz; }
            set { _modifyQuiz = value; }
        }

        //DataSet _myDataset = new DataSet();

        //public DataSet MyDataSet {
        //    get { return _myDataset; }
        //    set { _myDataset = value; }
        //}

        private string _activeQuiz;

        public string ActiveQuiz //(???) //Kanske kolla med TheQuizzMasterClass?
        {
            get { return _activeQuiz; }
            set { _activeQuiz = value; }
        }

        public EditQuiz() {

            InitializeComponent();
/*
            DataSet myDataset = new DataSet();
            myDataset.ReadXml(@Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\DoesThisChangeRoot.xml");//SuperherosNiklasVersion

            EditableDataGrid.ItemsSource = myDataset.Tables[0].DefaultView;
*/
            //EditableDataGrid

            //EditableDataGrid.DataContext = myDatagridContent;

        }

        private void LoadQuizClick(object sender, RoutedEventArgs e) {
            /*
                        //XAML: Command = "Open" //Kanske
                        OpenFileDialog openAnotherQuiz = new OpenFileDialog();
                        openAnotherQuiz.Filter = "Xml files (*.xml)|*.xml";
                        if (openAnotherQuiz.ShowDialog() == true) {

                            //FileStream fileStream = new FileStream(openAnotherQuiz.FileName, FileMode.Open);

                            //Quiz aNewQuiz = new Quiz();

                            saveAs_XML_Blueprint aNewQuiz = new saveAs_XML_Blueprint();

                            XmlSerializer serializer = new XmlSerializer(aNewQuiz.GetType());

                            TextReader textReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\" + "Valhalla" + ".xml");

                            //TextReader textReader = new StreamReader();

                            aNewQuiz = (saveAs_XML_Blueprint)serializer.Deserialize(textReader);

                            textReader.Close();

                            //string hello = aNewQuiz.Questions.Count().ToString();

                            //MessageBox.Show(hello);

                            //XElement quizFile = XElement.Load(@"quiz.xml");

                        }
            */



            /*
            OpenFileDialog openAnotherQuiz = new OpenFileDialog();
            openAnotherQuiz.Filter = "Xml files (*.xml)|*.xml";
            if (openAnotherQuiz.ShowDialog() == true) {

                saveAs_XML_Blueprint aNewQuiz = new saveAs_XML_Blueprint();

                //FillMeUpWithXML aNewQuiz = new FillMeUpWithXML();

                XmlSerializer serializer = new XmlSerializer(aNewQuiz.GetType(), new XmlRootAttribute("Quiz"));

                TextReader textReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\" + "DoesThisChangeRoot" + ".xml");

                //TextReader textReader = new StreamReader(Environment.GetFolderPath();

                aNewQuiz = (saveAs_XML_Blueprint)serializer.Deserialize(textReader);

                //aNewQuiz = (FillMeUpWithXML)serializer.Deserialize(textReader);

                textReader.Close();

                //MessageBox.Show(hello);
                


            } */




            /*
                         OpenFileDialog openAnotherQuiz = new OpenFileDialog();
                        openAnotherQuiz.Filter = "Xml files (*.xml)|*.xml";
                        if (openAnotherQuiz.ShowDialog() == true) {

                            saveAs_XML_Blueprint aNewQuiz = new saveAs_XML_Blueprint();

                            XmlSerializer serializer = new XmlSerializer(aNewQuiz.GetType(), new XmlRootAttribute("Quiz"));

                            //TextReader textReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\" + "DoesThisChangeRoot" + ".xml");

                            TextReader textReader = new StreamReader(openAnotherQuiz.FileName);

                            aNewQuiz = (saveAs_XML_Blueprint)serializer.Deserialize(textReader);

                            textReader.Close();

                            MessageBox.Show("Deserialization seems to have worked!\nBut how do I check it?");

                            DataSet myNewDataset = new DataSet();
                            myNewDataset.ReadXml(openAnotherQuiz.FileName);//SuperherosNiklasVersion
                            EditableDataGrid.ItemsSource = myNewDataset.Tables[0].DefaultView;

                            ModifyQuiz = openAnotherQuiz.FileName;

             */





            OpenFileDialog openAnotherQuiz = new OpenFileDialog();
            openAnotherQuiz.Filter = "Xml files (*.xml)|*.xml";
            if (openAnotherQuiz.ShowDialog() == true) {

                ANewQuiz = new saveAs_XML_Blueprint();

                XmlSerializer serializer = new XmlSerializer(ANewQuiz.GetType(), new XmlRootAttribute("Quiz"));

                //TextReader textReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\" + "DoesThisChangeRoot" + ".xml");

                TextReader textReader = new StreamReader(openAnotherQuiz.FileName);
                
                ANewQuiz = (saveAs_XML_Blueprint)serializer.Deserialize(textReader);

                textReader.Close();

                MessageBox.Show("Deserialization seems to have worked!\nBut how do I check it?");

                myNewDataset = new DataSet();
                myNewDataset.ReadXml(openAnotherQuiz.FileName);//SuperherosNiklasVersion
                EditableDataGrid.ItemsSource = myNewDataset.Tables[0].DefaultView;

                IsTheDatagridEmpty = false;
                
                ModifyQuiz = openAnotherQuiz.FileName;


                //PleaseLoadXML.Load(ModifyQuiz);


                /*
                TheQuizMasterClass iWantThoseValues = new TheQuizMasterClass(aNewQuiz.Statement, aNewQuiz.CorrectAnswer, new string[] {aNewQuiz.AnswerOne, aNewQuiz.AnswerTwo, aNewQuiz.AnswerThree});
                iWantThoseValues.NewQuiz.Title = openAnotherQuiz.FileName;
                
                return iWantThoseValues;
                */

                //newQuizStatements

                //(aNewQuiz.Statement, aNewQuiz.CorrectAnswer, new string[] { aNewQuiz.AnswerOne, aNewQuiz.AnswerTwo, aNewQuiz.AnswerThree });
                //Title = openAnotherQuiz.FileName;

                //return ();


                
            }
            else {

                //return default;

            }



        }

        private void SaveQuizClick(object sender, RoutedEventArgs e) {

            //DataSet currentDataSet = (DataSet)EditableDataGrid.DataContext;
            //currentDataSet.WriteXml(ModifyQuiz, XmlWriteMode.IgnoreSchema);//DatagridWrittenXML.xml

/*            saveAs_XML_Blueprint saveChangesToXML = new saveAs_XML_Blueprint();

            XElement xmlFile = XElement.Load(ModifyQuiz);
            xmlFile.Add(saveChangesToXML);

            xmlFile.Save(ModifyQuiz);
            DataSet anotherDataSet = new DataSet();
            anotherDataSet.ReadXml(ModifyQuiz);
            EditableDataGrid.ItemsSource = anotherDataSet.Tables[0].DefaultView;
*/



            if (IsTheDatagridEmpty == false) {

                //IsTheDatagridEmpty = true;

                /*

                                saveAs_XML_Blueprint saveChangesToXML = new saveAs_XML_Blueprint();

                                XElement xmlFile = XElement.Load(ModifyQuiz);
                                xmlFile.Add(saveChangesToXML);

                                xmlFile.Save(ModifyQuiz);
                                DataSet anotherDataSet = new DataSet();
                                anotherDataSet.ReadXml(ModifyQuiz);
                                EditableDataGrid.ItemsSource = anotherDataSet.Tables[0].DefaultView;

                 */

                /*
                saveAs_XML_Blueprint saveChangesToXML = new saveAs_XML_Blueprint();
                saveChangesToXML.Statement = "Hello";
                saveChangesToXML.CorrectAnswer = 2;
                saveChangesToXML.AnswerOne = "World";
                saveChangesToXML.AnswerTwo = "Quiz";
                saveChangesToXML.AnswerThree = "Human";
                */


                //               XElement xmlFile = XElement.Load(ModifyQuiz);
                // xmlFile.Add(saveChangesToXML);

                //xmlFile.Save(ModifyQuiz);
                //DataSet anotherDataSet = new DataSet();
                //anotherDataSet.ReadXml(ModifyQuiz);
                //EditableDataGrid.ItemsSource = anotherDataSet.Tables[0].DefaultView;





                /*
                //Sparar en xml utan taggar där den första har bara titel/attribut "Good day to you!"
                XmlDocument PleaseLoadXML = new XmlDocument();
                PleaseLoadXML.Load(ModifyQuiz);
                PleaseLoadXML.DocumentElement.InnerText = "Good day to you!";
                PleaseLoadXML.Save(ModifyQuiz);
                */


                /*
                XmlDocument PleaseLoadXML = new XmlDocument();
                PleaseLoadXML.Load(ModifyQuiz);
                PleaseLoadXML.DocumentElement.InnerText = "Good day to you!";
                PleaseLoadXML.Save(ModifyQuiz);
                */

                //DataSet anotherNewDataSet = new DataSet();
                //anotherNewDataSet.ReadXml(ModifyQuiz);
                //EditableDataGrid.ItemsSource = anotherNewDataSet.Tables[0].DefaultView;




                //DataSet anotherNewDataSet = new DataSet();
                //anotherNewDataSet.ReadXml(ModifyQuiz);
                //EditableDataGrid.ItemsSource = anotherNewDataSet.Tables[0].DefaultView;
                //anotherNewDataSet.AcceptChanges();


                //myNewDataset.AcceptChanges();





                //XmlDocument PleaseLoadXML = new XmlDocument();
                //PleaseLoadXML.Load(ModifyQuiz);
                //PleaseLoadXML.Save(ModifyQuiz);





                /*
                for (int i = 0; i < EditableDataGrid.Items.Count; i++) {

                    string columnOneValue = new string("");
                    string columnTwoValue = new string("");
                    string columnThreeValue = new string("");
                    string columnFourValue = new string("");
                    int columnFiveValue = new int();

                    for (int j = 0; j < 5; j++) {

                        //EditableDataGrid.CurrentColumn[i]; //.Index.ToString();

                        columnOneValue = EditableDataGrid.set[j].GetValue(this).ToString();

                    }

                    //for (int i = 0; i < EditableDataGrid.Items.Count; i++) {
                    //    EditableDataGrid.SelectedItems[i];
                    //}


                    myDatagridContent.Add(new saveAs_XML_Blueprint() { Statement = });

                }
                */


                



                EditableDataGrid.ItemsSource = myNewDataset.Tables[0].DefaultView;


                

                saveAs_XML_Blueprint editingQuizFile = new saveAs_XML_Blueprint();



                List<saveAs_XML_Blueprint> editingQuizList = new List<saveAs_XML_Blueprint>();




                /*
                    var items = dtSelectedTableValues.SelectedItems;
                    foreach (DataRowView item in items)
                */




                /*

                 foreach (DataGridRow row in rows) {  
                      DataRowView rowView = (DataRowView)row.Item;
                      foreach (DataGridColumn column in nameofyordatagrid.Columns)

                      if (column.GetCellContent(row) is TextBlock)
                           {
                            TextBlock cellContent = column.GetCellContent(row) as TextBlock;
                            MessageBox.Show(cellContent.Text);
                           }
                 
                 */




                /*

                //DataRowView datagridRow = EditableDataGrid.SelectedItems as DataRowView;

                //var questionParts = EditableDataGrid.SelectedItems;

                //Nedan ändrar ALLA celler till det i senaste cellen man ändrat...
                var questionParts = EditableDataGrid.Items.Count;

                for (int i = 0; i < questionParts; i++) {
                    
                    editingQuizFile.Statement = EditableDataGrid.SelectedCells[0].ToString();
                    editingQuizFile.AnswerOne = EditableDataGrid.SelectedCells[1].ToString();
                    editingQuizFile.AnswerTwo = EditableDataGrid.SelectedCells[2].ToString();
                    editingQuizFile.AnswerThree = EditableDataGrid.SelectedCells[3].ToString();

                    //var beingConverted = EditableDataGrid.SelectedCells[4].ToString();//Upset person: Who let that Age of Empires II monk in?!
                    //int conversionComplete = int.Parse(beingConverted);//Now calm person: Let us pray to the lord almighty.
                    
                    //editingQuizFile.CorrectAnswer = conversionComplete;

                    editingQuizList.Add(editingQuizFile);
                    
                }

                */




                //var questionParts = EditableDataGrid.Items.Count;

                //foreach (var item in EditableDataGrid.Items) {

                //for (int i = 0; i < questionParts/5; i++) {

                //    editingQuizFile.Statement = EditableDataGrid.SelectedCells[0].ToString();
                //    editingQuizFile.AnswerOne = EditableDataGrid.SelectedCells[1].ToString();
                //    editingQuizFile.AnswerTwo = EditableDataGrid.SelectedCells[2].ToString();
                //    editingQuizFile.AnswerThree = EditableDataGrid.SelectedCells[3].ToString();
                //     string oh = int.Parse(EditableDataGrid.SelectedCells[4].ToString());

                //     int 

                //    editingQuizList.Add(editingQuizFile);

                //}

                //}


                /*
                //Kopierar en rad till alla rader! Nästan där men inte samtidigt....
                for (int i = 0; i < EditableDataGrid.Items.Count; i++) {
                    
                DataRowView datagridRow = EditableDataGrid.SelectedItem as DataRowView;
                
               if (datagridRow != null) {

                    editingQuizFile.Statement = datagridRow[0].ToString();
                    editingQuizFile.AnswerOne = datagridRow[1].ToString();
                    editingQuizFile.AnswerTwo = datagridRow[2].ToString();
                    editingQuizFile.AnswerThree = datagridRow[3].ToString();

                    var beingConverted = datagridRow[4].ToString();//Upset person: Who let that Age of Empires II monk in?!
                    int conversionComplete = int.Parse(beingConverted);//Now calm person: Let us pray to the lord almighty.
                    
                    editingQuizFile.CorrectAnswer += conversionComplete;

                    editingQuizList.Add(editingQuizFile);

                    }

                }

                */



                //EditableDataGrid.CurrentCell = EditableDataGrid[1, 0];



                


                //Kopierar en rad till alla rader! Nästan där men inte samtidigt....
                for (int i = 0; i < EditableDataGrid.Items.Count; i++) {

                    DataRowView datagridRow = EditableDataGrid.ItemsSource as DataRowView;

                    if (datagridRow != null) {

                        //SelectedCells gör att det blir samma hela tiden... -.-
                        editingQuizFile.Statement = EditableDataGrid.SelectedCells[0].ToString();
                        editingQuizFile.AnswerOne = EditableDataGrid.SelectedCells[1].ToString();
                        editingQuizFile.AnswerTwo = EditableDataGrid.SelectedCells[2].ToString();
                        editingQuizFile.AnswerThree = EditableDataGrid.SelectedCells[3].ToString();

                        var beingConverted = EditableDataGrid.SelectedCells[4].ToString();//Upset person: Who let that Age of Empires II monk in?!
                        int conversionComplete = int.Parse(beingConverted);//Now calm person: Let us pray to the lord almighty.

                        editingQuizFile.CorrectAnswer += conversionComplete;

                        editingQuizList.Add(editingQuizFile);

                    }

                }




                /*//Spel Titel, Spelstudio, Pris, Varunummer
        public static string[] Game1 = new string[] { "Star Wars: Knights of the Old Republic", "BioWare Corp.", "299", "301" };
        public static string[] Game2 = new string[] { "Mass Effect", "BioWare", "179", "302" };
        public static string[] Game3 = new string[] { "Warlords Battlecry II", "SSG and Ubisoft", "189", "303" };
        public static string[] Game4 = new string[] { "Neverwinter Nights", "BioWare Corp.", "349", "304" };

        public static List<string[]> listOfGames = new List<string[]>() { Game1, Game2, Game3, Game4 };*/




                /*
                 *
                //DataRowView datagridRow = EditableDataGrid.SelectedItems as DataRowView;

                var questionParts = EditableDataGrid.SelectedItems;

                foreach (DataRowView part in questionParts) {
                    
                    editingQuizFile.Statement = part[0].ToString();
                    editingQuizFile.AnswerOne = part[1].ToString();
                    editingQuizFile.AnswerTwo = part[2].ToString();
                    editingQuizFile.AnswerThree = part[3].ToString();

                    var beingConverted = part[4].ToString();//Upset person: Who let that Age of Empires II monk in?!
                    int conversionComplete = int.Parse(beingConverted);//Now calm person: Let us pray to the lord almighty.
                    
                    editingQuizFile.CorrectAnswer = conversionComplete;

                    editingQuizList.Add(editingQuizFile);
                    
                }
                 *
                 */



                /*
                
                //Saves the selected row with new values. A step in the right direction.
                saveAs_XML_Blueprint editingQuizFile = new saveAs_XML_Blueprint();


                DataRowView datagridRow = EditableDataGrid.SelectedItem as DataRowView;
                if (datagridRow != null) {

                    editingQuizFile.Statement = datagridRow[0].ToString();
                    editingQuizFile.AnswerOne = datagridRow[1].ToString();
                    editingQuizFile.AnswerTwo = datagridRow[2].ToString();
                    editingQuizFile.AnswerThree = datagridRow[3].ToString();

                    var beingConverted = datagridRow[4].ToString();//Upset person: Who let that Age of Empires II monk in?!
                    int conversionComplete = int.Parse(beingConverted);//Now calm person: Let us pray to the lord almighty.
                    
                    editingQuizFile.CorrectAnswer = conversionComplete;

                } 
                 
                */


                //editingQuizFile.Statement = ;
                //editingQuizFile.AnswerOne = ;
                //editingQuizFile.AnswerTwo = ;
                //editingQuizFile.AnswerThree = ;
                //editingQuizFile.CorrectAnswer = ;

                //List<saveAs_XML_Blueprint> editingQuizList = new List<saveAs_XML_Blueprint>();
                //editingQuizList.Add(editingQuizFile);

                XmlSerializer serializer = new XmlSerializer(editingQuizList.GetType(), new XmlRootAttribute("Quiz"));

                TextWriter textWriter = new StreamWriter(ModifyQuiz);

                serializer.Serialize(textWriter, editingQuizList);

                textWriter.Close();


                string doneSavingMessage = "Your quiz has been edited.";

                string doneSavingTitle = "Quiz Edited";

                MessageBox.Show(doneSavingMessage, doneSavingTitle);









            } else {

                MessageBox.Show("Please load and edit a quiz first, before saving!", "Failed to edit Quiz");

            }



        }
        
        private void ClickedSwitchToCreateQuiz() {



        }

        private void ClickedSwitchToPlayQuiz() {



        }

        private void LoadSelectedQuizFile() {

            //DataSet myDataset = new DataSet();
            //myDataset.ReadXml(@Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\" +  + ".xml");

            //EditableDataGrid.ItemsSource = myDataset.Tables[0].DefaultView;

        }

        private void ShowQuizFile() {

            LoadQuiz showTheQuiz = new LoadQuiz();
            
            //EditableDataGrid = new BindableCollection<QuiICollection>(ICollection());

        }

        private void SaveQuizFile() {



        }

        public void AddData() {
        
        }

        /*
        private void somethingChangedInDatagrid(object sender, SelectionChangedEventArgs e) {

            DataGrid changedDatagrid = (DataGrid) sender;
            DataRowView datagridRow = changedDatagrid.SelectedItem as DataRowView;
            if (datagridRow != null) {



            }

        }
        */

        /*        public void Save_Btn_Click(object sender, RoutedEventArgs e) {
                    foreach (saveAs_XML_Blueprint items in myDatagridContent) {



                    }
                } */



    }
}


















//private DataTable GatherDatagridInformationToSaveToXML(/*DataGrid dataGrid*/) {

//    foreach (DataGridColumn datagridColumn in EditableDataGrid.Columns) {

//        if (datagridColumn.Visibility == Visibility.Visible) {

//            DatagridToSave.Columns.Add();

//        }

//    }

//    //object[] hhhhhcellValues = new object[dataGrid.Columns.Count];
//    DataGridCellInfo[] datagridCells = new DataGridCellInfo[EditableDataGrid.Columns.Count];

//    EditableDataGrid.RowDetailsVisibilityMode = Visibility.Visible;

//    //foreach (DataGridRow datagridRow in EditableDataGrid.Items.Count) { }

//    for (int i = 0; i < EditableDataGrid.Items.Count; i++) {

//        for (int j = 0; j < EditableDataGrid.Items.Count; j++) {

//            datagridCells[i] = RowDefinition

//        }

//    }

//}

















/*


namespace Labb_4 {

    public partial class CreateNewQuizQuestions : UserControl {

        private bool _isQuizInstanceAcceptingQuestionsAllready = false;
        private bool _areWeSavingRightNow = false;

        private TheQuizMasterClass _quizHolder;

        public TheQuizMasterClass QuizHolder {
            get { return _quizHolder; }
            set { _quizHolder = value; }
        }

        private List<saveAs_XML_Blueprint> _aQuestionList;

        public List<saveAs_XML_Blueprint> AQuestionList {
            get { return _aQuestionList; }
            set { _aQuestionList = value; }
        }

        private saveAs_XML_Blueprint _creatingQuizFile = new saveAs_XML_Blueprint();

        public saveAs_XML_Blueprint CreatingQuizFile {
            get { return _creatingQuizFile; }
            set { _creatingQuizFile = value; }
        }

        private int _counterForAQuestionList = 1;

        public int CounterForAQuestionList {

            get { return _counterForAQuestionList; }
            set { _counterForAQuestionList = value; }
        }

        public CreateNewQuizQuestions(string titleForNewQuiz) {

            AQuestionList = new List<saveAs_XML_Blueprint>();

        }

        private void AddQuestion() {

            int correctAnswerToTheNewQuestion = 0;

            if (RadioButtonAnswerOne.IsChecked == true) {

                correctAnswerToTheNewQuestion = 1;

            } else if (RadioButtonAnswerTwo.IsChecked == true) {

                correctAnswerToTheNewQuestion = 2;

            } else if (RadioButtonAnswerThree.IsChecked == true) {

                correctAnswerToTheNewQuestion = 3;

            }

            string newQuestion = NewQuestionTextBox.Text;

            string answerOneToTheNewQuestion = NewAnswerOneTextBox.Text;
            string answerTwoToTheNewQuestion = NewAnswerTwoTextBox.Text;
            string answerThreeToTheNewQuestion = NewAnswerThreeTextBox.Text;

            string[] answersToTheNewQuestion = new string[]
                {answerOneToTheNewQuestion, answerTwoToTheNewQuestion, answerThreeToTheNewQuestion};

            if (_isQuizInstanceAcceptingQuestionsAllready == false) {

                QuizHolder = new TheQuizMasterClass(newQuestion, correctAnswerToTheNewQuestion, answersToTheNewQuestion);

                _isQuizInstanceAcceptingQuestionsAllready = true;

            } else {

                QuizHolder.NewQuiz.Questions.Add(new Question(newQuestion, correctAnswerToTheNewQuestion,
                    answersToTheNewQuestion));

            }

            NewQuestionTextBox.Text = "";
            NewAnswerOneTextBox.Text = "";
            NewAnswerTwoTextBox.Text = "";
            NewAnswerThreeTextBox.Text = "";

            saveAs_XML_Blueprint creatingQuizFile = new saveAs_XML_Blueprint();
            creatingQuizFile.Statement = newQuestion;
            creatingQuizFile.AnswerOne = answerOneToTheNewQuestion;
            creatingQuizFile.AnswerTwo = answerTwoToTheNewQuestion;
            creatingQuizFile.AnswerThree = answerThreeToTheNewQuestion;
            creatingQuizFile.CorrectAnswer = correctAnswerToTheNewQuestion;

            AQuestionList.Add(creatingQuizFile);

            if (_areWeSavingRightNow == true) {

                _areWeSavingRightNow = false;

                XmlSerializer serializer = new XmlSerializer(AQuestionList.GetType(), new XmlRootAttribute("Quiz"));

                System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\");

                TextWriter textWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Niklas Eriksson\\Labb_4\\" + NewQuizTitle + ".xml");

                serializer.Serialize(textWriter, AQuestionList);

                textWriter.Close();


                string doneEditingMessage = "Your quiz has been edited.";

                string doneEditingTitle = "Quiz Edited";

                MessageBox.Show(doneEditingMessage, doneEditingTitle);

            }

        }

    }

}

*/




























/*

    //https://stackoverflow.com/questions/47862926/how-to-get-all-the-rows-from-datagrid-in-wpf/47864512
    ObservableCollection<gridContent> myDatagridContent { get; set; }
    MyClass() {
    theDatagrid.DataContext = myDatagridContent;
    }
    public void AddData() {
    myDatagridContent.Add(new gridContent() { // Add Values });
    }

    public void Save_Btn_Click(object sender, RoutedEventArgs e) {
        foreach (gridContent items in myDatagridContent) {
            // here get items using items.Prefix/year/....
        }
    }

*/










/*

//https://stackoverflow.com/questions/47862926/how-to-get-all-the-rows-from-datagrid-in-wpf/47864512
ObservableCollection<saveAs_XML_Blueprint> myDatagridContent { get; set; }
        MyClass()
        {
            EditableDataGrid.DataContext = myDatagridContent;
        }
        public void AddData() {
        myDatagridContent.Add(new saveAs_XML_Blueprint() { Statement, AnswerOne, AnswerTwo, AnswerThree, CorrectAnswer});
        }

        public void Save_Btn_Click(object sender, RoutedEventArgs e) {
            foreach (saveAs_XML_Blueprint items in myDatagridContent) {
                // here get items using items.Prefix/year/....
            }
        }

 */



/*

ObservableCollection<saveAs_XML_Blueprint> myDatagridContent { get; set; }
        MyClass()
        {
            EditableDataGrid.DataContext = myDatagridContent;
        }
        public void AddData() {
        myDatagridContent.Add(new saveAs_XML_Blueprint() { Statement, AnswerOne, AnswerTwo, AnswerThree, CorrectAnswer});
        }

        public void Save_Btn_Click(object sender, RoutedEventArgs e) {
            foreach (saveAs_XML_Blueprint items in myDatagridContent) {
                


            }
        }

*/






















/*
 *
 //https://stackoverflow.com/questions/16863531/iterating-through-rows-of-a-datagrid
                var itemsSource = EditableDataGrid.ItemsSource as IEnumerable;
                if (itemsSource != null) {
                    foreach (var item in itemsSource) {
                        var row = EditableDataGrid.ItemContainerGenerator.ContainerFromItem(item) as DataGridRow;
                        if (row != null) {
                            .....
                        }

                    }
                }
 *
 */









/*
    //https://www.codegrepper.com/code-examples/csharp/select+row+in+datagridview+c%23+by+its+column+value
        private void setCurrentCellButton_Click(object sender, System.EventArgs e)
    {
        // Set the current cell to the cell in column 1, Row 0. 
        this.dataGridView1.CurrentCell = this.dataGridView1[1,0];
    }
 */
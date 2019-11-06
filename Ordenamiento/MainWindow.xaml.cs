
using System.Windows;

using System.Collections.ObjectModel;

namespace Ordenamiento
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<int> miLista = new ObservableCollection<int>();
        ObservableCollection<Alumno> alumnos = new ObservableCollection<Alumno>();
        public MainWindow()
        {
            InitializeComponent();
            miLista.Add(10);
            miLista.Add(2);
            miLista.Add(53);
            miLista.Add(24);
            miLista.Add(65);
            miLista.Add(41);
            miLista.Add(9);
            miLista.Add(82);
            miLista.Add(9);
            miLista.Add(13);

            alumnos.Add(new Alumno("Jose", 9, 2));
            alumnos.Add(new Alumno("Maria", 8, 8));
            alumnos.Add(new Alumno("Pedro", 7, 9));
            alumnos.Add(new Alumno("Ana", 6, 15));
            alumnos.Add(new Alumno("Juan", 9, 2));
            alumnos.Add(new Alumno("Alexia", 10, 0));
            alumnos.Add(new Alumno("Pedro", 9, 1));

            lstNumeros.ItemsSource = alumnos;
            //lstNumeros.ItemsSource = miLista;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*var temp = miLista[0];
            miLista[0] = miLista[3];
            miLista[3] = temp;*/
            int gap, i, j;
            gap = miLista.Count / 2;

            while (gap > 0)
            {
                for (i = 0; i < alumnos.Count; i++)
                {



                    //utilizar otra lista, y cuando se evaluen no se hace directo de la lista, si un valor/propiedad de la lsta.
                    if (gap + i < alumnos.Count && alumnos[i].Faltas > alumnos[gap + i].Faltas)// un string no puede usar el <>
                    {
                        var temp = alumnos[i];

                        alumnos[i] = alumnos[gap + i];

                        alumnos[gap + i] = temp;//var, variable de tipo implicita

                    }


                }
                gap--; //restar uno 
            }
        }

        private void BtnBubble_Click(object sender, RoutedEventArgs e)
        {

            //bubble

            bool intercambio = false;
            do
            {

                intercambio = false;
                for (int i = 0; i < alumnos.Count - 1; i++) //i++ para modificar el valor de la i, peor solo se le quiere sumar 1
                {

                    if (alumnos[i].Faltas > alumnos[i + 1].Faltas)
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[i + 1];
                        alumnos[i + 1] = temp;
                        intercambio = true;
                    }


                }

            } while (intercambio);

        }

        private void Btnordenarnombres_Click(object sender, RoutedEventArgs e)
        {
            int gab, i, j;
            gab = alumnos.Count / 2; //el numero de elementos entre dos


            while (gab > 0)
            {
                for (i = 0; i < alumnos.Count; i++)
                {

                    //utilizar otra lista, y cuando se evaluen no se hace directo de la lista, si un valor/propiedad de la lsta.
                    if (gab + i < alumnos.Count && alumnos[i].Promedio > alumnos[gab + i].Promedio)// un string no puede usar el <>
                    {
                        var temp = alumnos[i];

                        alumnos[i] = alumnos[gab + i];

                        alumnos[gab + i] = temp;//var, variable de tipo implicita

                    }


                }
                gab--; //restar uno 
            }
        }

        private void Btnbubblepromedio_Click(object sender, RoutedEventArgs e)
        {
            bool intercambio = false;
            do
            {

                intercambio = false;
                for (int i = 0; i < alumnos.Count - 1; i++) //i++ para modificar el valor de la i, peor solo se le quiere sumar 1
                {

                    if (alumnos[i].Promedio > alumnos[i + 1].Promedio)
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[i + 1];
                        alumnos[i + 1] = temp;
                        intercambio = true;
                    }


                }

            } while (intercambio);
        }

        private void Btnshell_mas_Click(object sender, RoutedEventArgs e)
        {
            int gab, i, j;
            gab = alumnos.Count / 2; //el numero de elementos entre dos


            while (gab > 0)
            {
                for (i = 0; i < alumnos.Count; i++)
                {

                    //utilizar otra lista, y cuando se evaluen no se hace directo de la lista, si un valor/propiedad de la lsta.
                    if (gab + i < alumnos.Count && alumnos[i].Promedio > alumnos[gab + i].Promedio)// un string no puede usar el <>
                    {
                        var temp = alumnos[i];

                        alumnos[i] = alumnos[gab + i];

                        alumnos[gab - i] = temp;//var, variable de tipo implicita

                    }


                }
                gab--; //restar uno 
            }
        }
    }
}

   
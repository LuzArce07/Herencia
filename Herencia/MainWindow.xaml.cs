﻿using System;
using System.Collections.Generic;
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

namespace Herencia
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Animal> animales = new List<Animal>();

            Ave tucan = new Ave();
            tucan.Nombre = "Sam";
            animales.Add(tucan);

            Mamifero tigre = new Mamifero();
            tigre.Nombre = "Toño";
            animales.Add(tigre);

            Animal cocodrilo = new Reptil(); // esto si se puede
            cocodrilo.Nombre = "Godzilla";
            animales.Add(cocodrilo);

            Pez pezPayaso = new Pez();
            pezPayaso.Nombre = "Nemo";
            animales.Add(pezPayaso);

           
            foreach(Animal animal in animales)
            {   
                //Aqui accede a los elementos del Stackpanel
                stckRegistro.Children.Add(new TextBlock
                {
                    Text = animal.desplazar()
                } );

            }

            imprimir(tucan.ponerHuevo());
            imprimir(((Reptil)cocodrilo).cambiarPiel()); //esto es un casting
            
        }

        public void imprimir(string texto)
        {
            stckRegistro.Children.Add(new TextBlock
            {
                Text = texto 
            } );

        }

    }

}

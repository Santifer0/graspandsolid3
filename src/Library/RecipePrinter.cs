//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{

    public class RecipePrinter : Printer
    {

        public void print(Recipe recipe)
        {

            
                File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());

        }
    }
}
/*
  _______________________________________________________________
 /                                                               \
||  Course: CSCI-473    Assignment #: 4  Semester: Spring 2021   ||
||                                                               ||
||  NAME1:  Rhianna Eberle                 Z-ID: z1848017        ||
||                                                               ||
||  NAME2:  Dillion Chappell                 Z-ID: z1761203      ||
||                                                               ||
||  NAME3: Karen Astorga                    Z-ID: z176117        ||
||                                                               ||
||  Professor: Daniel Rogness                                    ||
||                                                               ||
||  Due: Thursday 3/18/2021 by 11:59PM                           ||
||                                                               ||
||  Description:                                                 ||
||     This file is the main file.                               ||
||                                                               ||
 \_______________________________________________________________/
*/

using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks; 
using System.Windows.Forms; 

 
namespace ChappellEberleAstorga_Assign4
{ 
      static class Program 
     { 
         /// <summary> 
         /// The main entry point for the application. 
        /// </summary> 
       [STAThread] 
       static void Main() 
      { 
          Application.EnableVisualStyles(); 
            Application.SetCompatibleTextRenderingDefault(false); 
            Application.Run(new Form1()); 
       } 
     } 
 } 


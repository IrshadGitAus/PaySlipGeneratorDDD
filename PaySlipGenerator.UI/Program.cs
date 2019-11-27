﻿using PaySlipGenerator.Core.Interfaces;
using PaySlipGenerator.Core.Services;
using PaySlipGenerator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using PaySlipGenerator.Infrastructure.Interfaces;

namespace PaySlipGeneratorNew
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            ExerciseContainerConfigurator.RegisterDependencies();
            var employeePaySlipService = ExerciseContainerConfigurator.ExerciseContainer.Resolve<IEmployeePaySlipService>();
            var outputFileWriter = ExerciseContainerConfigurator.ExerciseContainer.Resolve<IOutputWriter>();
            Application.Run(new MYOBExercise(employeePaySlipService, outputFileWriter));
        }
    }
}

using Data;
using Microsoft.EntityFrameworkCore;
using Model;
using Repository;
using System;
using Controller;

class Program
{
    static void Main(string[] args)
    {
        var controller = Controlador.AdquirirControlador();
        controller.ExecutarPrograma();
    }
}

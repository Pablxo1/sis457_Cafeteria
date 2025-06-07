﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadCafeteria;

namespace ClnCafeteria
{
    public class ClientesCln
    {
        public static int insertar(Cliente cliente)
        {
            using (var context = new LabCafeteriaEntities())
            {
                context.Cliente.Add(cliente);
                context.SaveChanges();
                return cliente.id;
            }
        }

        public static int actualizar(Cliente cliente)
        {
            using (var context = new LabCafeteriaEntities())
            {
                var existente = context.Cliente.Find(cliente.id);
                existente.cedulaIdentidad = cliente.cedulaIdentidad;
                existente.nombres = cliente.nombres;
                existente.apellidos = cliente.apellidos;
                existente.usuarioRegistro = cliente.usuarioRegistro;
                return context.SaveChanges();
            }
        }

        public static int eliminar(int id, string usuario)
        {
            using (var context = new LabCafeteriaEntities())
            {
                var cliente = context.Cliente.Find(id);
                cliente.estado = -1;
                cliente.usuarioRegistro = usuario;
                return context.SaveChanges();
            }
        }

        public static Cliente obtenerUno(int id)
        {
            using (var context = new LabCafeteriaEntities())
            {
                return context.Cliente.Find(id);
            }
        }

        public static List<Cliente> listar()
        {
            using (var context = new LabCafeteriaEntities())
            {
                return context.Cliente.Where(x => x.estado != -1).ToList();
            }
        }
        public static List<paClienteListar_Result> listarPa(string parametro)
        {
            using (var context = new LabCafeteriaEntities())
            {
                return context.paClienteListar(parametro).ToList();
            }
        }
    }
}

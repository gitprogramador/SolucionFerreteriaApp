﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace FerreteriaApp.bdatosfer
{

    [Persistent(@"rol")]
    public partial class Rol : XPLiteObject
    {
        int fIdRol;
        [Key(true)]
        public int IdRol
        {
            get { return fIdRol; }
            set { SetPropertyValue<int>(nameof(IdRol), ref fIdRol, value); }
        }
        string fDescripcion;
        [Size(50)]
        public string Descripcion
        {
            get { return fDescripcion; }
            set { SetPropertyValue<string>(nameof(Descripcion), ref fDescripcion, value); }
        }
        [Association(@"UsuarioReferencesRol")]
        public XPCollection<Usuario> Usuarios { get { return GetCollection<Usuario>(nameof(Usuarios)); } }
    }

}
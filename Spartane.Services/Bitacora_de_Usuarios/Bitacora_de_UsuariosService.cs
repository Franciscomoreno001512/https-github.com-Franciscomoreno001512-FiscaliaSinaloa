using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Bitacora_de_Usuarios;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Bitacora_de_Usuarios
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Bitacora_de_UsuariosService : IBitacora_de_UsuariosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios> _Bitacora_de_UsuariosRepository;
        #endregion

        #region Ctor
        public Bitacora_de_UsuariosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios> Bitacora_de_UsuariosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Bitacora_de_UsuariosRepository = Bitacora_de_UsuariosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios> SelAll(bool ConRelaciones)
        {
            return this._Bitacora_de_UsuariosRepository.Table.ToList();
        }

        public IList<Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios> SelAllComplete(bool ConRelaciones)
        {
            return this._Bitacora_de_UsuariosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Bitacora_de_UsuariosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Bitacora_de_UsuariosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Bitacora_de_UsuariosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_UsuariosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Bitacora_de_UsuariosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Bitacora_de_UsuariosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Bitacora_de_UsuariosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios entity, Spartane.Core.Domain.User.GlobalData Bitacora_de_UsuariosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Bitacora_de_Usuarios.Bitacora_de_Usuarios entity, Spartane.Core.Domain.User.GlobalData Bitacora_de_UsuariosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}


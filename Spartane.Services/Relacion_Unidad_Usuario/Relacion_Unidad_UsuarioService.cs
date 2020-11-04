using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Relacion_Unidad_Usuario;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Relacion_Unidad_Usuario
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Relacion_Unidad_UsuarioService : IRelacion_Unidad_UsuarioService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario> _Relacion_Unidad_UsuarioRepository;
        #endregion

        #region Ctor
        public Relacion_Unidad_UsuarioService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario> Relacion_Unidad_UsuarioRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Relacion_Unidad_UsuarioRepository = Relacion_Unidad_UsuarioRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario> SelAll(bool ConRelaciones)
        {
            return this._Relacion_Unidad_UsuarioRepository.Table.ToList();
        }

        public IList<Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario> SelAllComplete(bool ConRelaciones)
        {
            return this._Relacion_Unidad_UsuarioRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Relacion_Unidad_UsuarioRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Relacion_Unidad_UsuarioRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Relacion_Unidad_UsuarioRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_UsuarioPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Relacion_Unidad_UsuarioPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Relacion_Unidad_UsuarioRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Relacion_Unidad_UsuarioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario entity, Spartane.Core.Domain.User.GlobalData Relacion_Unidad_UsuarioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Relacion_Unidad_Usuario.Relacion_Unidad_Usuario entity, Spartane.Core.Domain.User.GlobalData Relacion_Unidad_UsuarioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}


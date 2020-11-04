using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Usuario;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Usuario
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class UsuarioService : IUsuarioService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Usuario.Usuario> _UsuarioRepository;
        #endregion

        #region Ctor
        public UsuarioService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Usuario.Usuario> UsuarioRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._UsuarioRepository = UsuarioRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Usuario.Usuario> SelAll(bool ConRelaciones)
        {
            return this._UsuarioRepository.Table.ToList();
        }

        public IList<Core.Domain.Usuario.Usuario> SelAllComplete(bool ConRelaciones)
        {
            return this._UsuarioRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Usuario.Usuario> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._UsuarioRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Usuario.Usuario> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._UsuarioRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Usuario.Usuario> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._UsuarioRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Usuario.UsuarioPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            UsuarioPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Usuario.Usuario> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._UsuarioRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Usuario.Usuario GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Usuario.Usuario result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData UsuarioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Usuario.Usuario entity, Spartane.Core.Domain.User.GlobalData UsuarioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Usuario.Usuario entity, Spartane.Core.Domain.User.GlobalData UsuarioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}


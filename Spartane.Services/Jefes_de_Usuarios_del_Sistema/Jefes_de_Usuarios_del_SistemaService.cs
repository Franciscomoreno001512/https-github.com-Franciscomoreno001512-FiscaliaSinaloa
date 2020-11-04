using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Jefes_de_Usuarios_del_Sistema
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Jefes_de_Usuarios_del_SistemaService : IJefes_de_Usuarios_del_SistemaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema> _Jefes_de_Usuarios_del_SistemaRepository;
        #endregion

        #region Ctor
        public Jefes_de_Usuarios_del_SistemaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema> Jefes_de_Usuarios_del_SistemaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Jefes_de_Usuarios_del_SistemaRepository = Jefes_de_Usuarios_del_SistemaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema> SelAll(bool ConRelaciones)
        {
            return this._Jefes_de_Usuarios_del_SistemaRepository.Table.ToList();
        }

        public IList<Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema> SelAllComplete(bool ConRelaciones)
        {
            return this._Jefes_de_Usuarios_del_SistemaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Jefes_de_Usuarios_del_SistemaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Jefes_de_Usuarios_del_SistemaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Jefes_de_Usuarios_del_SistemaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_SistemaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Jefes_de_Usuarios_del_SistemaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Jefes_de_Usuarios_del_SistemaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Jefes_de_Usuarios_del_SistemaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema entity, Spartane.Core.Domain.User.GlobalData Jefes_de_Usuarios_del_SistemaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Jefes_de_Usuarios_del_Sistema.Jefes_de_Usuarios_del_Sistema entity, Spartane.Core.Domain.User.GlobalData Jefes_de_Usuarios_del_SistemaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}


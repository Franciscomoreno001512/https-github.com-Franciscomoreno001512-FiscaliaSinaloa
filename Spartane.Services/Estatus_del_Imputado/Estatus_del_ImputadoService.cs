using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Estatus_del_Imputado;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Estatus_del_Imputado
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Estatus_del_ImputadoService : IEstatus_del_ImputadoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Estatus_del_Imputado.Estatus_del_Imputado> _Estatus_del_ImputadoRepository;
        #endregion

        #region Ctor
        public Estatus_del_ImputadoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Estatus_del_Imputado.Estatus_del_Imputado> Estatus_del_ImputadoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Estatus_del_ImputadoRepository = Estatus_del_ImputadoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Estatus_del_Imputado.Estatus_del_Imputado> SelAll(bool ConRelaciones)
        {
            return this._Estatus_del_ImputadoRepository.Table.ToList();
        }

        public IList<Core.Domain.Estatus_del_Imputado.Estatus_del_Imputado> SelAllComplete(bool ConRelaciones)
        {
            return this._Estatus_del_ImputadoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Estatus_del_Imputado.Estatus_del_Imputado> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estatus_del_ImputadoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estatus_del_Imputado.Estatus_del_Imputado> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Estatus_del_ImputadoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estatus_del_Imputado.Estatus_del_Imputado> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estatus_del_ImputadoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estatus_del_Imputado.Estatus_del_ImputadoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Estatus_del_ImputadoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Estatus_del_Imputado.Estatus_del_Imputado> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Estatus_del_ImputadoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estatus_del_Imputado.Estatus_del_Imputado GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Estatus_del_Imputado.Estatus_del_Imputado result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Estatus_del_ImputadoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Estatus_del_Imputado.Estatus_del_Imputado entity, Spartane.Core.Domain.User.GlobalData Estatus_del_ImputadoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Estatus_del_Imputado.Estatus_del_Imputado entity, Spartane.Core.Domain.User.GlobalData Estatus_del_ImputadoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}


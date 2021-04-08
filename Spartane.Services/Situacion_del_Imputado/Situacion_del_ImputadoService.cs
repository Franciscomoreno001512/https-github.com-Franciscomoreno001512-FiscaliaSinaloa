using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Situacion_del_Imputado;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Situacion_del_Imputado
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Situacion_del_ImputadoService : ISituacion_del_ImputadoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado> _Situacion_del_ImputadoRepository;
        #endregion

        #region Ctor
        public Situacion_del_ImputadoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado> Situacion_del_ImputadoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Situacion_del_ImputadoRepository = Situacion_del_ImputadoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado> SelAll(bool ConRelaciones)
        {
            return this._Situacion_del_ImputadoRepository.Table.ToList();
        }

        public IList<Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado> SelAllComplete(bool ConRelaciones)
        {
            return this._Situacion_del_ImputadoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Situacion_del_ImputadoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Situacion_del_ImputadoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Situacion_del_ImputadoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_ImputadoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Situacion_del_ImputadoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Situacion_del_ImputadoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Situacion_del_ImputadoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado entity, Spartane.Core.Domain.User.GlobalData Situacion_del_ImputadoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Situacion_del_Imputado.Situacion_del_Imputado entity, Spartane.Core.Domain.User.GlobalData Situacion_del_ImputadoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}


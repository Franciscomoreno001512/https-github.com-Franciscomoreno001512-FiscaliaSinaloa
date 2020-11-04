using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Situacion_Fisica;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Situacion_Fisica
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Situacion_FisicaService : ISituacion_FisicaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica> _Situacion_FisicaRepository;
        #endregion

        #region Ctor
        public Situacion_FisicaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica> Situacion_FisicaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Situacion_FisicaRepository = Situacion_FisicaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica> SelAll(bool ConRelaciones)
        {
            return this._Situacion_FisicaRepository.Table.ToList();
        }

        public IList<Core.Domain.Situacion_Fisica.Situacion_Fisica> SelAllComplete(bool ConRelaciones)
        {
            return this._Situacion_FisicaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Situacion_FisicaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Situacion_FisicaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Situacion_FisicaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Situacion_Fisica.Situacion_FisicaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Situacion_FisicaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Situacion_FisicaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Situacion_FisicaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica entity, Spartane.Core.Domain.User.GlobalData Situacion_FisicaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Situacion_Fisica.Situacion_Fisica entity, Spartane.Core.Domain.User.GlobalData Situacion_FisicaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}


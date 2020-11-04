using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Discapacidades_Sensoriales;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Discapacidades_Sensoriales
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Discapacidades_SensorialesService : IDiscapacidades_SensorialesService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales> _Discapacidades_SensorialesRepository;
        #endregion

        #region Ctor
        public Discapacidades_SensorialesService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales> Discapacidades_SensorialesRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Discapacidades_SensorialesRepository = Discapacidades_SensorialesRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales> SelAll(bool ConRelaciones)
        {
            return this._Discapacidades_SensorialesRepository.Table.ToList();
        }

        public IList<Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales> SelAllComplete(bool ConRelaciones)
        {
            return this._Discapacidades_SensorialesRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Discapacidades_SensorialesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Discapacidades_SensorialesRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Discapacidades_SensorialesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_SensorialesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Discapacidades_SensorialesPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Discapacidades_SensorialesRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Discapacidades_SensorialesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales entity, Spartane.Core.Domain.User.GlobalData Discapacidades_SensorialesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Discapacidades_Sensoriales.Discapacidades_Sensoriales entity, Spartane.Core.Domain.User.GlobalData Discapacidades_SensorialesInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}


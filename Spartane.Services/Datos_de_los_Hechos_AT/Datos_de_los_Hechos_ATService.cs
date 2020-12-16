using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Datos_de_los_Hechos_AT;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Datos_de_los_Hechos_AT
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Datos_de_los_Hechos_ATService : IDatos_de_los_Hechos_ATService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Datos_de_los_Hechos_AT.Datos_de_los_Hechos_AT> _Datos_de_los_Hechos_ATRepository;
        #endregion

        #region Ctor
        public Datos_de_los_Hechos_ATService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Datos_de_los_Hechos_AT.Datos_de_los_Hechos_AT> Datos_de_los_Hechos_ATRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Datos_de_los_Hechos_ATRepository = Datos_de_los_Hechos_ATRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Datos_de_los_Hechos_AT.Datos_de_los_Hechos_AT> SelAll(bool ConRelaciones)
        {
            return this._Datos_de_los_Hechos_ATRepository.Table.ToList();
        }

        public IList<Core.Domain.Datos_de_los_Hechos_AT.Datos_de_los_Hechos_AT> SelAllComplete(bool ConRelaciones)
        {
            return this._Datos_de_los_Hechos_ATRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Datos_de_los_Hechos_AT.Datos_de_los_Hechos_AT> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Datos_de_los_Hechos_ATRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Datos_de_los_Hechos_AT.Datos_de_los_Hechos_AT> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Datos_de_los_Hechos_ATRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Datos_de_los_Hechos_AT.Datos_de_los_Hechos_AT> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Datos_de_los_Hechos_ATRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Datos_de_los_Hechos_AT.Datos_de_los_Hechos_ATPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Datos_de_los_Hechos_ATPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Datos_de_los_Hechos_AT.Datos_de_los_Hechos_AT> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Datos_de_los_Hechos_ATRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Datos_de_los_Hechos_AT.Datos_de_los_Hechos_AT GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Datos_de_los_Hechos_AT.Datos_de_los_Hechos_AT result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Datos_de_los_Hechos_ATInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Datos_de_los_Hechos_AT.Datos_de_los_Hechos_AT entity, Spartane.Core.Domain.User.GlobalData Datos_de_los_Hechos_ATInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Datos_de_los_Hechos_AT.Datos_de_los_Hechos_AT entity, Spartane.Core.Domain.User.GlobalData Datos_de_los_Hechos_ATInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}


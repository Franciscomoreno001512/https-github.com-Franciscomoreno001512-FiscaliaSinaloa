using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Detalle_Audiencia_Defensor_Victima
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Detalle_Audiencia_Defensor_VictimaService : IDetalle_Audiencia_Defensor_VictimaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_Victima> _Detalle_Audiencia_Defensor_VictimaRepository;
        #endregion

        #region Ctor
        public Detalle_Audiencia_Defensor_VictimaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_Victima> Detalle_Audiencia_Defensor_VictimaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Detalle_Audiencia_Defensor_VictimaRepository = Detalle_Audiencia_Defensor_VictimaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_Victima> SelAll(bool ConRelaciones)
        {
            return this._Detalle_Audiencia_Defensor_VictimaRepository.Table.ToList();
        }

        public IList<Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_Victima> SelAllComplete(bool ConRelaciones)
        {
            return this._Detalle_Audiencia_Defensor_VictimaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_Victima> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Audiencia_Defensor_VictimaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_Victima> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Detalle_Audiencia_Defensor_VictimaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_Victima> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Detalle_Audiencia_Defensor_VictimaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_VictimaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Detalle_Audiencia_Defensor_VictimaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_Victima> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Detalle_Audiencia_Defensor_VictimaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_Victima GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_Victima result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Detalle_Audiencia_Defensor_VictimaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_Victima entity, Spartane.Core.Domain.User.GlobalData Detalle_Audiencia_Defensor_VictimaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Detalle_Audiencia_Defensor_Victima.Detalle_Audiencia_Defensor_Victima entity, Spartane.Core.Domain.User.GlobalData Detalle_Audiencia_Defensor_VictimaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}


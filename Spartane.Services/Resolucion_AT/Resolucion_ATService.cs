using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Resolucion_AT;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Resolucion_AT
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Resolucion_ATService : IResolucion_ATService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Resolucion_AT.Resolucion_AT> _Resolucion_ATRepository;
        #endregion

        #region Ctor
        public Resolucion_ATService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Resolucion_AT.Resolucion_AT> Resolucion_ATRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Resolucion_ATRepository = Resolucion_ATRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Resolucion_AT.Resolucion_AT> SelAll(bool ConRelaciones)
        {
            return this._Resolucion_ATRepository.Table.ToList();
        }

        public IList<Core.Domain.Resolucion_AT.Resolucion_AT> SelAllComplete(bool ConRelaciones)
        {
            return this._Resolucion_ATRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Resolucion_AT.Resolucion_AT> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Resolucion_ATRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Resolucion_AT.Resolucion_AT> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Resolucion_ATRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Resolucion_AT.Resolucion_AT> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Resolucion_ATRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Resolucion_AT.Resolucion_ATPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Resolucion_ATPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Resolucion_AT.Resolucion_AT> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Resolucion_ATRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Resolucion_AT.Resolucion_AT GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Resolucion_AT.Resolucion_AT result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Resolucion_ATInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Resolucion_AT.Resolucion_AT entity, Spartane.Core.Domain.User.GlobalData Resolucion_ATInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Resolucion_AT.Resolucion_AT entity, Spartane.Core.Domain.User.GlobalData Resolucion_ATInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}


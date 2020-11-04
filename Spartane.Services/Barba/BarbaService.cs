using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Barba;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Barba
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class BarbaService : IBarbaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Barba.Barba> _BarbaRepository;
        #endregion

        #region Ctor
        public BarbaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Barba.Barba> BarbaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._BarbaRepository = BarbaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Barba.Barba> SelAll(bool ConRelaciones)
        {
            return this._BarbaRepository.Table.ToList();
        }

        public IList<Core.Domain.Barba.Barba> SelAllComplete(bool ConRelaciones)
        {
            return this._BarbaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Barba.Barba> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._BarbaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Barba.Barba> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._BarbaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Barba.Barba> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._BarbaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Barba.BarbaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            BarbaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Barba.Barba> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._BarbaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Barba.Barba GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Barba.Barba result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData BarbaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Barba.Barba entity, Spartane.Core.Domain.User.GlobalData BarbaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Barba.Barba entity, Spartane.Core.Domain.User.GlobalData BarbaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}


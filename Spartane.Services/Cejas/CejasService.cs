using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Cejas;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Cejas
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class CejasService : ICejasService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Cejas.Cejas> _CejasRepository;
        #endregion

        #region Ctor
        public CejasService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Cejas.Cejas> CejasRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._CejasRepository = CejasRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Cejas.Cejas> SelAll(bool ConRelaciones)
        {
            return this._CejasRepository.Table.ToList();
        }

        public IList<Core.Domain.Cejas.Cejas> SelAllComplete(bool ConRelaciones)
        {
            return this._CejasRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Cejas.Cejas> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._CejasRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Cejas.Cejas> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._CejasRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Cejas.Cejas> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._CejasRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Cejas.CejasPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            CejasPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Cejas.Cejas> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._CejasRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Cejas.Cejas GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Cejas.Cejas result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData CejasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Cejas.Cejas entity, Spartane.Core.Domain.User.GlobalData CejasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Cejas.Cejas entity, Spartane.Core.Domain.User.GlobalData CejasInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}


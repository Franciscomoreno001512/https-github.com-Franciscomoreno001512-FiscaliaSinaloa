using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Plazo_Constitucional;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Plazo_Constitucional
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Plazo_ConstitucionalService : IPlazo_ConstitucionalService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Plazo_Constitucional.Plazo_Constitucional> _Plazo_ConstitucionalRepository;
        #endregion

        #region Ctor
        public Plazo_ConstitucionalService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Plazo_Constitucional.Plazo_Constitucional> Plazo_ConstitucionalRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Plazo_ConstitucionalRepository = Plazo_ConstitucionalRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Plazo_Constitucional.Plazo_Constitucional> SelAll(bool ConRelaciones)
        {
            return this._Plazo_ConstitucionalRepository.Table.ToList();
        }

        public IList<Core.Domain.Plazo_Constitucional.Plazo_Constitucional> SelAllComplete(bool ConRelaciones)
        {
            return this._Plazo_ConstitucionalRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Plazo_Constitucional.Plazo_Constitucional> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Plazo_ConstitucionalRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Plazo_Constitucional.Plazo_Constitucional> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Plazo_ConstitucionalRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Plazo_Constitucional.Plazo_Constitucional> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Plazo_ConstitucionalRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Plazo_Constitucional.Plazo_ConstitucionalPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Plazo_ConstitucionalPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Plazo_Constitucional.Plazo_Constitucional> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Plazo_ConstitucionalRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Plazo_Constitucional.Plazo_Constitucional GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Plazo_Constitucional.Plazo_Constitucional result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Plazo_ConstitucionalInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Plazo_Constitucional.Plazo_Constitucional entity, Spartane.Core.Domain.User.GlobalData Plazo_ConstitucionalInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Plazo_Constitucional.Plazo_Constitucional entity, Spartane.Core.Domain.User.GlobalData Plazo_ConstitucionalInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}


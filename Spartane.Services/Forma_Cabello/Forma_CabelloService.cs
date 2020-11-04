using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Forma_Cabello;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Forma_Cabello
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Forma_CabelloService : IForma_CabelloService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Forma_Cabello.Forma_Cabello> _Forma_CabelloRepository;
        #endregion

        #region Ctor
        public Forma_CabelloService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Forma_Cabello.Forma_Cabello> Forma_CabelloRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Forma_CabelloRepository = Forma_CabelloRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Forma_Cabello.Forma_Cabello> SelAll(bool ConRelaciones)
        {
            return this._Forma_CabelloRepository.Table.ToList();
        }

        public IList<Core.Domain.Forma_Cabello.Forma_Cabello> SelAllComplete(bool ConRelaciones)
        {
            return this._Forma_CabelloRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Forma_Cabello.Forma_Cabello> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Forma_CabelloRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Forma_Cabello.Forma_Cabello> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Forma_CabelloRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Forma_Cabello.Forma_Cabello> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Forma_CabelloRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Forma_Cabello.Forma_CabelloPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Forma_CabelloPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Forma_Cabello.Forma_Cabello> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Forma_CabelloRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Forma_Cabello.Forma_Cabello GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Forma_Cabello.Forma_Cabello result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Forma_CabelloInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Forma_Cabello.Forma_Cabello entity, Spartane.Core.Domain.User.GlobalData Forma_CabelloInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Forma_Cabello.Forma_Cabello entity, Spartane.Core.Domain.User.GlobalData Forma_CabelloInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}


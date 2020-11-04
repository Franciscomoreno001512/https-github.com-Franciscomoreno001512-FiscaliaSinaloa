using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Largo_de_Cabello;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Largo_de_Cabello
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Largo_de_CabelloService : ILargo_de_CabelloService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Largo_de_Cabello.Largo_de_Cabello> _Largo_de_CabelloRepository;
        #endregion

        #region Ctor
        public Largo_de_CabelloService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Largo_de_Cabello.Largo_de_Cabello> Largo_de_CabelloRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Largo_de_CabelloRepository = Largo_de_CabelloRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Largo_de_Cabello.Largo_de_Cabello> SelAll(bool ConRelaciones)
        {
            return this._Largo_de_CabelloRepository.Table.ToList();
        }

        public IList<Core.Domain.Largo_de_Cabello.Largo_de_Cabello> SelAllComplete(bool ConRelaciones)
        {
            return this._Largo_de_CabelloRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Largo_de_Cabello.Largo_de_Cabello> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Largo_de_CabelloRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Largo_de_Cabello.Largo_de_Cabello> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Largo_de_CabelloRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Largo_de_Cabello.Largo_de_Cabello> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Largo_de_CabelloRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Largo_de_Cabello.Largo_de_CabelloPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Largo_de_CabelloPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Largo_de_Cabello.Largo_de_Cabello> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Largo_de_CabelloRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Largo_de_Cabello.Largo_de_Cabello GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Largo_de_Cabello.Largo_de_Cabello result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Largo_de_CabelloInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Largo_de_Cabello.Largo_de_Cabello entity, Spartane.Core.Domain.User.GlobalData Largo_de_CabelloInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Largo_de_Cabello.Largo_de_Cabello entity, Spartane.Core.Domain.User.GlobalData Largo_de_CabelloInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}


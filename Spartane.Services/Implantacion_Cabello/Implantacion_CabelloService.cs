using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Implantacion_Cabello;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Implantacion_Cabello
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Implantacion_CabelloService : IImplantacion_CabelloService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Implantacion_Cabello.Implantacion_Cabello> _Implantacion_CabelloRepository;
        #endregion

        #region Ctor
        public Implantacion_CabelloService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Implantacion_Cabello.Implantacion_Cabello> Implantacion_CabelloRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Implantacion_CabelloRepository = Implantacion_CabelloRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Implantacion_Cabello.Implantacion_Cabello> SelAll(bool ConRelaciones)
        {
            return this._Implantacion_CabelloRepository.Table.ToList();
        }

        public IList<Core.Domain.Implantacion_Cabello.Implantacion_Cabello> SelAllComplete(bool ConRelaciones)
        {
            return this._Implantacion_CabelloRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Implantacion_Cabello.Implantacion_Cabello> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Implantacion_CabelloRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Implantacion_Cabello.Implantacion_Cabello> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Implantacion_CabelloRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Implantacion_Cabello.Implantacion_Cabello> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Implantacion_CabelloRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Implantacion_Cabello.Implantacion_CabelloPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Implantacion_CabelloPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Implantacion_Cabello.Implantacion_Cabello> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Implantacion_CabelloRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Implantacion_Cabello.Implantacion_Cabello GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Implantacion_Cabello.Implantacion_Cabello result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Implantacion_CabelloInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Implantacion_Cabello.Implantacion_Cabello entity, Spartane.Core.Domain.User.GlobalData Implantacion_CabelloInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Implantacion_Cabello.Implantacion_Cabello entity, Spartane.Core.Domain.User.GlobalData Implantacion_CabelloInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}


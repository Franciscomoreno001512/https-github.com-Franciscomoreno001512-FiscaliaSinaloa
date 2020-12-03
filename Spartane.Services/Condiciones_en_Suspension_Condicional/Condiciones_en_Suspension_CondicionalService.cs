using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Condiciones_en_Suspension_Condicional;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Condiciones_en_Suspension_Condicional
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Condiciones_en_Suspension_CondicionalService : ICondiciones_en_Suspension_CondicionalService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional> _Condiciones_en_Suspension_CondicionalRepository;
        #endregion

        #region Ctor
        public Condiciones_en_Suspension_CondicionalService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional> Condiciones_en_Suspension_CondicionalRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Condiciones_en_Suspension_CondicionalRepository = Condiciones_en_Suspension_CondicionalRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional> SelAll(bool ConRelaciones)
        {
            return this._Condiciones_en_Suspension_CondicionalRepository.Table.ToList();
        }

        public IList<Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional> SelAllComplete(bool ConRelaciones)
        {
            return this._Condiciones_en_Suspension_CondicionalRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Condiciones_en_Suspension_CondicionalRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Condiciones_en_Suspension_CondicionalRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Condiciones_en_Suspension_CondicionalRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_CondicionalPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Condiciones_en_Suspension_CondicionalPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Condiciones_en_Suspension_CondicionalRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Condiciones_en_Suspension_CondicionalInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional entity, Spartane.Core.Domain.User.GlobalData Condiciones_en_Suspension_CondicionalInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Condiciones_en_Suspension_Condicional.Condiciones_en_Suspension_Condicional entity, Spartane.Core.Domain.User.GlobalData Condiciones_en_Suspension_CondicionalInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}


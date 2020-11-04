using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Grosor_de_Labios;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Grosor_de_Labios
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Grosor_de_LabiosService : IGrosor_de_LabiosService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios> _Grosor_de_LabiosRepository;
        #endregion

        #region Ctor
        public Grosor_de_LabiosService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios> Grosor_de_LabiosRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Grosor_de_LabiosRepository = Grosor_de_LabiosRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios> SelAll(bool ConRelaciones)
        {
            return this._Grosor_de_LabiosRepository.Table.ToList();
        }

        public IList<Core.Domain.Grosor_de_Labios.Grosor_de_Labios> SelAllComplete(bool ConRelaciones)
        {
            return this._Grosor_de_LabiosRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Grosor_de_LabiosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Grosor_de_LabiosRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Grosor_de_LabiosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_LabiosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Grosor_de_LabiosPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Grosor_de_LabiosRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Grosor_de_LabiosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios entity, Spartane.Core.Domain.User.GlobalData Grosor_de_LabiosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Grosor_de_Labios.Grosor_de_Labios entity, Spartane.Core.Domain.User.GlobalData Grosor_de_LabiosInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}


using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Tipo_de_Plantio;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Tipo_de_Plantio
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Tipo_de_PlantioService : ITipo_de_PlantioService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio> _Tipo_de_PlantioRepository;
        #endregion

        #region Ctor
        public Tipo_de_PlantioService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio> Tipo_de_PlantioRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Tipo_de_PlantioRepository = Tipo_de_PlantioRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio> SelAll(bool ConRelaciones)
        {
            return this._Tipo_de_PlantioRepository.Table.ToList();
        }

        public IList<Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio> SelAllComplete(bool ConRelaciones)
        {
            return this._Tipo_de_PlantioRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_de_PlantioRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Tipo_de_PlantioRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tipo_de_PlantioRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_PlantioPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Tipo_de_PlantioPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Tipo_de_PlantioRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Tipo_de_PlantioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio entity, Spartane.Core.Domain.User.GlobalData Tipo_de_PlantioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Tipo_de_Plantio.Tipo_de_Plantio entity, Spartane.Core.Domain.User.GlobalData Tipo_de_PlantioInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}


using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Clasificacion_de_Artefacto_y_Explosivo
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Clasificacion_de_Artefacto_y_ExplosivoService : IClasificacion_de_Artefacto_y_ExplosivoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo> _Clasificacion_de_Artefacto_y_ExplosivoRepository;
        #endregion

        #region Ctor
        public Clasificacion_de_Artefacto_y_ExplosivoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo> Clasificacion_de_Artefacto_y_ExplosivoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Clasificacion_de_Artefacto_y_ExplosivoRepository = Clasificacion_de_Artefacto_y_ExplosivoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo> SelAll(bool ConRelaciones)
        {
            return this._Clasificacion_de_Artefacto_y_ExplosivoRepository.Table.ToList();
        }

        public IList<Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo> SelAllComplete(bool ConRelaciones)
        {
            return this._Clasificacion_de_Artefacto_y_ExplosivoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Clasificacion_de_Artefacto_y_ExplosivoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Clasificacion_de_Artefacto_y_ExplosivoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Clasificacion_de_Artefacto_y_ExplosivoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_ExplosivoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Clasificacion_de_Artefacto_y_ExplosivoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Clasificacion_de_Artefacto_y_ExplosivoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Clasificacion_de_Artefacto_y_ExplosivoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo entity, Spartane.Core.Domain.User.GlobalData Clasificacion_de_Artefacto_y_ExplosivoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Clasificacion_de_Artefacto_y_Explosivo.Clasificacion_de_Artefacto_y_Explosivo entity, Spartane.Core.Domain.User.GlobalData Clasificacion_de_Artefacto_y_ExplosivoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}


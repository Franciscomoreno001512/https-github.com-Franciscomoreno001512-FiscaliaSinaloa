using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Clasificacion_en_Orden_de_Resultado
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Clasificacion_en_Orden_de_ResultadoService : IClasificacion_en_Orden_de_ResultadoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado> _Clasificacion_en_Orden_de_ResultadoRepository;
        #endregion

        #region Ctor
        public Clasificacion_en_Orden_de_ResultadoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado> Clasificacion_en_Orden_de_ResultadoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Clasificacion_en_Orden_de_ResultadoRepository = Clasificacion_en_Orden_de_ResultadoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado> SelAll(bool ConRelaciones)
        {
            return this._Clasificacion_en_Orden_de_ResultadoRepository.Table.ToList();
        }

        public IList<Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado> SelAllComplete(bool ConRelaciones)
        {
            return this._Clasificacion_en_Orden_de_ResultadoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Clasificacion_en_Orden_de_ResultadoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Clasificacion_en_Orden_de_ResultadoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Clasificacion_en_Orden_de_ResultadoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_ResultadoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Clasificacion_en_Orden_de_ResultadoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Clasificacion_en_Orden_de_ResultadoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Clasificacion_en_Orden_de_ResultadoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado entity, Spartane.Core.Domain.User.GlobalData Clasificacion_en_Orden_de_ResultadoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado entity, Spartane.Core.Domain.User.GlobalData Clasificacion_en_Orden_de_ResultadoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}


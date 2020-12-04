using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Resultado_de_Investigacion_Complementaria;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Resultado_de_Investigacion_Complementaria
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Resultado_de_Investigacion_ComplementariaService : IResultado_de_Investigacion_ComplementariaService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Resultado_de_Investigacion_Complementaria.Resultado_de_Investigacion_Complementaria> _Resultado_de_Investigacion_ComplementariaRepository;
        #endregion

        #region Ctor
        public Resultado_de_Investigacion_ComplementariaService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Resultado_de_Investigacion_Complementaria.Resultado_de_Investigacion_Complementaria> Resultado_de_Investigacion_ComplementariaRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Resultado_de_Investigacion_ComplementariaRepository = Resultado_de_Investigacion_ComplementariaRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Resultado_de_Investigacion_Complementaria.Resultado_de_Investigacion_Complementaria> SelAll(bool ConRelaciones)
        {
            return this._Resultado_de_Investigacion_ComplementariaRepository.Table.ToList();
        }

        public IList<Core.Domain.Resultado_de_Investigacion_Complementaria.Resultado_de_Investigacion_Complementaria> SelAllComplete(bool ConRelaciones)
        {
            return this._Resultado_de_Investigacion_ComplementariaRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Resultado_de_Investigacion_Complementaria.Resultado_de_Investigacion_Complementaria> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Resultado_de_Investigacion_ComplementariaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Resultado_de_Investigacion_Complementaria.Resultado_de_Investigacion_Complementaria> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Resultado_de_Investigacion_ComplementariaRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Resultado_de_Investigacion_Complementaria.Resultado_de_Investigacion_Complementaria> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Resultado_de_Investigacion_ComplementariaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Resultado_de_Investigacion_Complementaria.Resultado_de_Investigacion_ComplementariaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Resultado_de_Investigacion_ComplementariaPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Resultado_de_Investigacion_Complementaria.Resultado_de_Investigacion_Complementaria> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Resultado_de_Investigacion_ComplementariaRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Resultado_de_Investigacion_Complementaria.Resultado_de_Investigacion_Complementaria GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Resultado_de_Investigacion_Complementaria.Resultado_de_Investigacion_Complementaria result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Resultado_de_Investigacion_ComplementariaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Resultado_de_Investigacion_Complementaria.Resultado_de_Investigacion_Complementaria entity, Spartane.Core.Domain.User.GlobalData Resultado_de_Investigacion_ComplementariaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Resultado_de_Investigacion_Complementaria.Resultado_de_Investigacion_Complementaria entity, Spartane.Core.Domain.User.GlobalData Resultado_de_Investigacion_ComplementariaInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}


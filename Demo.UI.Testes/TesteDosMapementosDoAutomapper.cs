﻿using AutoMapper;
using Demo.UI.Mvc.Infra;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo.UI.Testes
{
    [TestClass]
    public class TesteDosMapementosDoAutomapper
    {
        [TestMethod]
        public void Verifica_Se_Configuração_Do_AutoMapper_Está_Correta()
        {
            ConfiguraçãoAutoMapper.Inicializar();
            Mapper.Configuration.AssertConfigurationIsValid();
        }
    }
}
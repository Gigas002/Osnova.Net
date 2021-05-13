﻿using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class VacancyTests
    {
        [SetUp]
        public void Setup() => Constants.CreateClient();

        [Test]
        public async Task GetJobs()
        {
            var jobs = await Vacancy.GetJobsAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);
        }
    }
}

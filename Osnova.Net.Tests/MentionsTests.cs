﻿#if LOCALTESTS

using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class MentionsTests
    {
        [SetUp]
        public void Setup() => Constants.CreateClient();

        [Test]
        public async Task GetSearchForMentions()
        {
            var mentionedUsers = await Mentions.GetSearchForMentionsAsync(Constants.Client, Constants.Kind, "yurucamp").ConfigureAwait(false);
        }

        [Test]
        public async Task GetEnableMentionNotifications()
        {
            var isEnabled = await Mentions.GetEnableMentionNotificationsAsync(Constants.Client, Constants.Kind, 732383).ConfigureAwait(false);
        }
    }
}

#endif

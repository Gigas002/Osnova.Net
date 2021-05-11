# Osnova.Net

Библиотека для работы с [API основы](https://cmtt-ru.github.io/osnova-api/redoc.html) версии 1.9.

[![Build status](https://ci.appveyor.com/api/projects/status/feuu4sm52kko3krd?svg=true)](https://ci.appveyor.com/project/Gigas002/osnova-net)

[![Actions Status](https://github.com/Gigas002/Osnova.Net/workflows/.NET%20Core%20CI/badge.svg)](https://github.com/Gigas002/Osnova.Net/actions)

## Текущая версия

NuGet: [![NuGet](https://img.shields.io/nuget/v/Osnova.Net.svg)](https://www.nuget.org/packages/Osnova.Net/);

GitHub Packages Feed: <https://github.com/Gigas002/Osnova.Net/packages>.

GitHub Releases: [![Release](https://img.shields.io/github/release/Gigas002/Osnova.Net.svg)](https://github.com/Gigas002/Osnova.Net/releases/latest);

Информация об изменениях в [CHANGELOG.md](CHANGELOG.md).

Система версий библиотеки -- [SemVer 2.0.0](https://semver.org/) (версия считается так: `{MAJOR}.{MINOR}.{PATCH}.{BUILD}`).

## Реализовано

- [ ] WebSocket (Частично реализовано, смотреть классы `WebSocketClient` и `WebSockets`)
- [x] Authentication (Через `Core.CreateDefaultClient(string authenticationToken)`)
- [x] Auth (нужны дополнительные тесты)
    - [x] postAuthQr (Спасибо Prostagma? за помощь с получением qr-кода)
    - [x] postAuthSocial
    - [x] postAuthLogin
- [ ] Timeline
    - [ ] getTimeline
    - [ ] getTimelineByHashtag
    - [ ] getTimelineNews
    - [ ] getFlashHolder
- [ ] Entry
    - [x] getEntryById
    - [x] getPopularEntries
    - [ ] postLikeEntry
    - [ ] postEntryCreate
    - [x] getEntryLocate
    - [ ] postEntryAttachEmbed
- [ ] Comment
    - [ ] getEntryComments
    - [ ] getEntryCommentsLevelsGet
    - [ ] getEntryCommentsThread
    - [ ] getCommentLikes
    - [ ] postCommentEdit
    - [ ] postCommentSend
    - [ ] postCommentSaveCommentsSeenCount
    - [ ] getEntryWidgets
- [ ] Upload
    - [ ] postUploaderUpload
    - [ ] postUploaderExtract
- [ ] Other
    - [ ] getLocate
    - [ ] postEntryComplaint
    - [ ] postEntryCommentComplaint
- [ ] Search
    - [ ] getSearch
    - [ ] getSearchSubsite
    - [ ] getSearchHashtag
    - [ ] getTag
- [ ] User
    - [x] getUser
    - [x] getUserMe
    - [x] getUserMeUpdates
    - [x] getUserMeUpdatesCount
    - [ ] postUserMeUpdatesReadId
    - [ ] postUserMeUpdatesRead
    - [x] getUserComments
    - [x] getUserMeComments
    - [x] getUserEntries
    - [x] getUserMeEntries
    - [x] getUserFavoritesEntries
    - [x] getUserFavoritesComments
    - [x] getUserFavoritesVacancies
    - [x] getUserMeFavoritesEntries
    - [x] getUserMeFavoritesComments
    - [x] getUserMeFavoritesVacancies
    - [x] getUserMeSubscriptionsRecommended
    - [x] getUserMeSubscriptionsSubscribed
    - [ ] postFavoriteAdd
    - [ ] postFavoriteRemove
    - [ ] getUserMeTuneCatalog
    - [ ] postUserMeTuneCatalog
    - [ ] postUserMeSaveAvatar
    - [ ] postUserMeSaveCover
    - [ ] postUserMeSubscription
    - [ ] getGetIgnoredKeywords
    - [ ] postSubsiteIgnoreKeywords
- [ ] Layout
    - [ ] getLayout
    - [ ] getLayoutHashtag
- [ ] Push
    - [ ] getUserPushTopic
    - [ ] getUserPushSettings
    - [ ] postUpdateUserPushSettings
- [ ] Payments
    - [ ] getPaymentsCheck
- [ ] Tweets
    - [ ] getTweets
- [ ] Widgets
    - [ ] getRates
- [ ] Subsite
    - [ ] getSubsite
    - [ ] getSubsiteTimeline
    - [ ] getSubsitesList
    - [ ] getSubsiteVacancies
    - [ ] getSubsiteVacanciesMore
    - [ ] getSubsiteSubscribe
    - [ ] getSubsiteUnsubscribe
    - [ ] postUserMeSubscription
- [ ] Vacancies
    - [ ] getJob
    - [ ] getJobMore
    - [ ] getJobFilters
    - [ ] getVacancies
- [ ] Webhooks Subscriptions
    - [ ] getApiWebhooksGet
    - [ ] postApiWebhookAdd
    - [ ] postApiWebhookDel
- [ ] Blacklist
    - [ ] postContentMute
    - [ ] postHashtagMute
    - [ ] postSubsitegMute
    - [ ] getIgnoresHashtags
    - [ ] getIgnoresSubsites
- [ ] Quiz
    - [ ] getQuizResults
    - [ ] postQuizVote
    - [ ] postQuizVoteReset
- [ ] Mentions
    - [ ] getSearchForMentions
    - [ ] getEnableMentionNotifications
    - [ ] getDisableMentionNotifications
- [ ] Events
    - [ ] getEventsFilters
    - [ ] getEvents
    - [ ] getEventsMore

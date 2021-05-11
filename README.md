# Osnova.Net

![Icon](Assets/icon.png)

Библиотека для работы с [API основы](https://cmtt-ru.github.io/osnova-api/redoc.html) версии **1.9**.

[![Build status](https://ci.appveyor.com/api/projects/status/feuu4sm52kko3krd?svg=true)](https://ci.appveyor.com/project/Gigas002/osnova-net)

[![Actions Status](https://github.com/Gigas002/Osnova.Net/workflows/.NET%20Core%20CI/badge.svg)](https://github.com/Gigas002/Osnova.Net/actions)

## Текущая версия

Библиотеку можно скачать на **NuGet**: [![NuGet](https://img.shields.io/nuget/v/Osnova.Net.svg)](https://www.nuget.org/packages/Osnova.Net/), через [GitHub Packages Feed](https://github.com/Gigas002/Osnova.Net/packages) либо собрать из исходного кода в этом репозитории.

Автобилды программы **OsnovaImageDownloader** через CI/CD загружаются в **GitHub Releases**: [![Release](https://img.shields.io/github/release/Gigas002/Osnova.Net.svg)](https://github.com/Gigas002/Osnova.Net/releases/latest).

Информация об изменениях в [CHANGELOG.md](CHANGELOG.md).

Система версий библиотеки -- [SemVer 2.0.0](https://semver.org/) (версия считается так: `{MAJOR}.{MINOR}.{PATCH}.{BUILD}`).

## Прогресс

Что реализовано на данный момент можно посмотреть [тут](https://github.com/Gigas002/Osnova.Net/issues/1).

Другие запланированные изменения будут появляться в [projects](https://github.com/Gigas002/Osnova.Net/projects)/[milestones](https://github.com/Gigas002/Osnova.Net/milestones).

## Примеры работы с API

Смотрите исходный код [тестов](https://github.com/Gigas002/Osnova.Net/tree/master/Osnova.Net.Tests).

## Сборка из исходного кода

Как самый минимум нужен только [NET 5.0 SDK](https://dotnet.microsoft.com/download/dotnet) и любой текстовый редактор. У библиотеки нет внешних зависимостей, так что собирается просто командой `dotnet build Osnova.Net/Osnova.Net.csproj` даже на компьютерах без интернета и настроенного источника пакетов nuget.

## 3rd party resources

Иконка -- обрезанное `D` с [лого DTF](https://ru.wikipedia.org/wiki/DTF#/media/%D0%A4%D0%B0%D0%B9%D0%BB:DTF_logo.svg).

#!/usr/bin/env bash
set -e

dotnet-gitversion /nocache /config .pipeline/GitVersion.yml |
jq '{ Major, Minor, Patch, MajorMinorPatch, SemVer, AssemblySemVer, AssemblySemFileVer, FullSemVer, InformationalVersion, BranchName, Sha, VersionSourceSha, CommitsSinceVersionSource }'

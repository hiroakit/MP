#!/usr/bin/env bash

# If any command fails, it will be aborted.
set -o errexit 

mp_csproj="./src/GraGadGet.Mp/GraGadGet.Mp.csproj"

help() {
cat <<EOF
Usage: sh $(basename "$0") command

Build assistant.

Command:
  build     Run "dotnet build".
  publish   Run "dotnet publish".
EOF
}

parse_args() {
    if [ "$#" -eq 0 ]; then
        help
        exit 1
    fi
    command="$1"
}

build() {
    dotnet build $mp_csproj
}

publish() {
    dotnet publish $mp_csproj -c Release -r osx-x64 /p:PublishSingleFile=true -o ./build/osx-x64
    dotnet publish $mp_csproj -c Release -r win-x64 /p:PublishSingleFile=true /p:IncludeNativeLibrariesForSelfExtract=true -o ./build/win-x64
    dotnet publish $mp_csproj -c Release -r linux-x64 /p:PublishSingleFile=true -o ./build/linux-x64
}

# archive() {

# }

parse_args "$@"
case "$command" in
    "build")
        build
        exit 0
        ;;
    "publish")
        publish
        exit 0
        ;;    
    # "archive")
    #     archive
    #     exit 0
    #     ;;      
esac
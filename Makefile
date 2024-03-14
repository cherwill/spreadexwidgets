CSC = dotnet

SOLUTION_DIR := .
PROJECT_DIR := Widgets
TEST_PROJECT_DIR := Widgets.Tests
SOLUTION_FILE := $(SOLUTION_DIR)/Widgets.sln

all: build test

build:
	dotnet build $(SOLUTION_FILE)

test:
	dotnet test $(TEST_PROJECT_DIR)/$(TEST_PROJECT_DIR).csproj

clean:
	dotnet clean $(SOLUTION_FILE)

run: build
	dotnet run --project $(PROJECT_DIR)/$(PROJECT_DIR).csproj
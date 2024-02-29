CSC = dotnet

SOLUTION_DIR := .
PROJECT_DIR := SpreadexWidgets
TEST_PROJECT_DIR := SpreadexWidgets.Tests
SOLUTION_FILE := $(SOLUTION_DIR)/SpreadexWidgets.sln

all: build test

build:
	dotnet build $(SOLUTION_FILE)

test:
	dotnet test $(TEST_PROJECT_DIR)/$(TEST_PROJECT_DIR).csproj

clean:
	dotnet clean $(SOLUTION_FILE)

run: build
	dotnet run --project $(PROJECT_DIR)/$(PROJECT_DIR).csproj
#!/bin/bash
set -e
service mysql start
mysql < /mysql/library.context.sql
service mysql stop
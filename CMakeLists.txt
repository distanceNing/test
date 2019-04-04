cmake_minimum_required(VERSION 3.13)
project(Fortest)

set(CMAKE_CXX_STANDARD 14)

#递归将所有源文件加入build列表
file(GLOB_RECURSE src_file
        "*.cpp"
        )
add_executable(Fortest ${src_file})
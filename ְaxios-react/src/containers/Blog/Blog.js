import React, { Component } from 'react';
import Post from '../../components/Post/Post';
import FullPost from '../../components/FullPost/FullPost';
import NewPost from '../../components/NewPost/NewPost';
import './Blog.css';
import axios from '../../axios'
class Blog extends Component {
   
state={
    posts:[],
    seletedpost:null
}

    componentDidMount(){
       axios.get('/posts').then(x=>{
            console.log(x.data)
            const post=x.data.slice(0,4);
            const post_autor=post.map(x=>{
                return{
                    ...x,
author:"david"
                }
            })
             
            this.setState({posts:post_autor})
        });
    }
    selectedHandler(id){
       this.setState({seletedpost:id}) 
    }
    render() {
      const post=  this.state.posts.map(p=>{
            return <Post key={p.id} title={p.title} author={p.author} clicked={()=>this.selectedHandler(p.id)}></Post>
                              })
        return (
            <div>
                <section className="Posts">
                {post}
                </section>
                <section>
                    <FullPost id={this.state.seletedpost}/>
                </section>
                <section>
                    <NewPost/>
                </section>
            </div>
        );
    }
}

export default Blog;